using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeepScore : MonoBehaviour
{
    public static int Score = 1000;
    public Text scoreUI;

    void FixedUpdate()
    {
         scoreUI.text = Score.ToString();
    }
}
