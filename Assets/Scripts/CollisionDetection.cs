using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    [DllImport("__Internal")]
    private static extern void SendScore(int score);

    private void OnCollisionEnter(Collision collision)
    {
        /*if(collision.transform.name != "Ground")
        {
            KeepScore.Score += 100;
        }*/
        KeepScore.Score += 100;

#if (UNITY_WEBGL == true && UNITY_EDITOR == false)
    SendScore (KeepScore.Score);
#endif

    }
}
