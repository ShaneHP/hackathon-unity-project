using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeepScore : MonoBehaviour
{
    public Text scoreUI;

    void FixedUpdate()
    {
         scoreUI.text = GameDifficulty.Score.ToString();
    }
}
