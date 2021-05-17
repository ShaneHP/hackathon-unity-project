using System.Collections;
using System.Collections.Generic;
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

    private void OnCollisionEnter(Collision collision)
    {
        /*if(collision.transform.name != "Ground")
        {
            KeepScore.Score += 100;
        }*/
        KeepScore.Score += 100;
    }
}
