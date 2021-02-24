using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TimerText : MonoBehaviour
{
    public LevelTimer timer;
    public Text changingText;
    void Update()
    {
        changingText.text = "Time : "+timer.actualTime;
        
    }
}