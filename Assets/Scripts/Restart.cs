using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    private bool fastMode = false;
    public GameDifficulty gameDifficulty;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            RestartGame();
        }

        if (Input.GetKeyDown(KeyCode.B) && fastMode == false)
        {
            fastMode = true;
            Time.timeScale = 3f;
        } 
        else if (Input.GetKeyDown(KeyCode.B))
        {
            fastMode = false;
            Time.timeScale = 1f;
        }
    }

    public void RestartGame()
    {
        gameDifficulty.setDifficulty(GameDifficulty.currentDifficulty);
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
    }
}
