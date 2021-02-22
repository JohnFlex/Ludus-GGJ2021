using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirFlowBehaviour : MonoBehaviour
{
    public float airForce = 10f;
    Rigidbody2D rb;

    [SerializeField]
    GameObject[] pipes;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        

        if (collision.gameObject.TryGetComponent<Rigidbody2D>(out Rigidbody2D tempRB))
        {
            rb = tempRB;
        }
        else
        {
            Debug.Log("No RB found");
        }
        
    }

   /* private void OnTriggerStay2D(Collider2D collision)
    {
        if (rb != null)
        {
            rb.AddForce(transform.up * airForce * Time.deltaTime, ForceMode2D.Impulse);
        }
        if (PlayerMovement.nowMoving)
        {
            foreach (GameObject item in pipes)
            {
                item.SetActive(false);
            }
        }
        else
        {
            foreach (GameObject item in pipes)
            {
                item.SetActive(true);
            }
        }

    }*/

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (rb != null)
        {
            rb.velocity.Normalize();
            rb = null;
        }

        foreach (GameObject item in pipes)
        {
            item.SetActive(false);
        }
    }

}
