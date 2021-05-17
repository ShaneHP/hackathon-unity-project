using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndTrigger : MonoBehaviour
{
    public GameManager gameManager;
    public Text finalScore;
    private void OnTriggerEnter(Collider other)
    {
        gameManager.CompleteLevel();
        finalScore.text = "$" + KeepScore.Score.ToString();
    }
}
