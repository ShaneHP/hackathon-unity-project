using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class GameManager : MonoBehaviour
{
    public GameObject completeLevelUI;
    public Text finalScore;
    public Text finalTime;
    public GameObject scoreUI;

    public void CompleteLevel()
    {
        Timer.timerActive = false;
        TimeSpan time = TimeSpan.FromSeconds(Timer.currentTime);
        finalTime.text = time.ToString((@"mm\:ss\:ff"));
        finalScore.text = "$" + KeepScore.Score.ToString();
        completeLevelUI.SetActive(true);
        scoreUI.SetActive(false);
    }
}
