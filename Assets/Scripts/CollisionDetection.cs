using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
    [DllImport("__Internal")]
    private static extern void SendScore(int score);
    public GameManager gameManager;

    private void OnCollisionEnter(Collision collision)
    {
        /*if(collision.transform.name != "Ground")
        {
            KeepScore.Score += 100;
        }*/
        KeepScore.Score -= 100;
        if(KeepScore.Score <= 0)
        {
            gameManager.FailLevel();
        }

#if (UNITY_WEBGL == true && UNITY_EDITOR == false)
    SendScore (KeepScore.Score);
#endif

    }
}
