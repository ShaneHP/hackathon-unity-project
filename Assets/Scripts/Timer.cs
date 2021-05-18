using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public static bool timerActive = false;
    public static float currentTime;
    public Text timerUI;
    // Start is called before the first frame update
    void Start()
    {
        currentTime = 0;
        timerActive = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(timerActive == true)
        {
            currentTime = currentTime + Time.deltaTime;
        }
        else
        {
            timerUI.enabled = false;
        }
        TimeSpan time = TimeSpan.FromSeconds(currentTime);
        timerUI.text = time.ToString(@"mm\:ss\:ff");
    }
}
