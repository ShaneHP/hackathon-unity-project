using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class GameManager : MonoBehaviour
{
    public GameObject completeLevelUI;
    public GameObject failLevelUI;
    public Text finalScore;
    public Text finalTime;
    public Text scoreUI;
    public Text scoreLabel;
    public Text timerUI;
    public Text difficultyLabel;
    public Text difficulty;

    public void CompleteLevel()
    {
        Timer.timerActive = false;
        timerUI.enabled = false;
        TimeSpan time = TimeSpan.FromSeconds(Timer.currentTime);
        finalTime.text = time.ToString((@"mm\:ss\:ff"));
        finalScore.text = GameDifficulty.Score.ToString();
        difficultyLabel.enabled = false;
        difficulty.enabled = false;
        completeLevelUI.SetActive(true);
        scoreUI.enabled = false;
        scoreLabel.enabled = false;
        Time.timeScale = 0f;
    }

    public void FailLevel()
    {
        Debug.Log("YOU FAILED");
        Timer.timerActive = false;
        timerUI.enabled = false;
        scoreUI.enabled = false;
        scoreLabel.enabled = false;
        difficultyLabel.enabled = false;
        difficulty.enabled = false;
        failLevelUI.SetActive(true);
        Time.timeScale = 0f;
    }
}
