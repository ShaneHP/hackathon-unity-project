using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameDifficulty : MonoBehaviour
{
    public static int StartMinutes = 2;
    public static int Score = 2000;

    public void setDifficulty(string difficulty)
    {
        if(difficulty.Equals("easy", StringComparison.CurrentCultureIgnoreCase))
        {
            Score = 3000;
            StartMinutes = 3;
        }
        else if(difficulty.Equals("medium", StringComparison.CurrentCultureIgnoreCase))
        {
            Score = 2000;
            StartMinutes = 2;
        }
        else if (difficulty.Equals("hard", StringComparison.CurrentCultureIgnoreCase))
        {
            Score = 1000;
            StartMinutes = 1;
        }
    }
}
