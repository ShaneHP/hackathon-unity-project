using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public static bool timerActive = false;
    public static float currentTime;
    private int startMinutes = 1;
    public Text timerUI;
    public GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = startMinutes * 60;
        timerActive = true;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(timerActive == true)
        {
            currentTime = currentTime - Time.deltaTime;
            if(currentTime <= 0)
            {
                timerActive = false;
                gameManager.FailLevel();
            }
        }
        TimeSpan time = TimeSpan.FromSeconds(currentTime);
        timerUI.text = time.ToString(@"mm\:ss\:ff");
    }
}
