using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager gameManager;
 
    private void OnTriggerEnter(Collider other)
    {
        if(other.transform.name == "Car")
        {
            gameManager.CompleteLevel();
        }
    }
}
