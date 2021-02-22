using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchBehavior : MonoBehaviour
{

    public GameObject[] toActivateWhenOn;
    public GameObject[] toDesactivateWhenOn;
    bool isOn = false;
    bool isInTrigger;

    MainControls controls;

    private void Awake()
    {
        controls = new MainControls();

        controls.Default.ActivateItem.performed += _ => Switch();

        foreach (GameObject item in toDesactivateWhenOn)
        {
            item.SetActive(false);
        }
    }

    private void OnEnable()
    {
        controls.Default.Enable();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            isInTrigger = true;
            gameObject.transform.GetChild(0).gameObject.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            isInTrigger = false;
            gameObject.transform.GetChild(0).gameObject.SetActive(false);
        }
    }

    void Switch()
    {
        if (isInTrigger)
        {
            isOn = !isOn;

            foreach (GameObject item in toActivateWhenOn)
            {
                item.SetActive(isOn);
            }
            foreach (GameObject item in toDesactivateWhenOn)
            {
                item.SetActive(!isOn);
            }
        }
    }

    private void OnDisable()
    {
        controls.Default.Disable();
    }
}
