using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StaminaText : MonoBehaviour
{
    public GhostModePlayer ghostScript;
    public Text changingText;

    // Update is called once per frame
    void Update()
    {
        changingText.text = "Stamina : " + ghostScript.stamina;
    }
}