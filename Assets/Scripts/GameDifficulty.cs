using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameDifficulty : MonoBehaviour
{
    public static int StartMinutes = 2;
    public static int Score = 2000;
    public static string currentDifficulty = "Medium";
    public Text difficultyUI;

    public void Start()
    {
        //setDifficulty("hard");
        Timer.currentTime = StartMinutes * 60;
        //Time.timeScale = 0f;   
    }

    public void setDifficulty(string difficulty)
    {
        if(difficulty.Equals("Easy", StringComparison.CurrentCultureIgnoreCase))
        {
            Score = 3000;
            StartMinutes = 3;
            currentDifficulty = "Easy";
        }
        else if(difficulty.Equals("Medium", StringComparison.CurrentCultureIgnoreCase))
        {
            Score = 2000;
            StartMinutes = 2;
            currentDifficulty = "Medium";
        }
        else if (difficulty.Equals("Hard", StringComparison.CurrentCultureIgnoreCase))
        {
            Score = 1000;
            StartMinutes = 1;
            currentDifficulty = "Hard";
        }
        SceneManager.LoadScene(0);
    }

    public void FixedUpdate()
    {
        difficultyUI.text = currentDifficulty;
    }
}
