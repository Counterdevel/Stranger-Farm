using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public static bool gameispaused = false;

    public GameObject PauseMenuUI;
    public GameObject InfoMenuUI;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {

            if (gameispaused)
            {
                Resume();
            }
            else
            {
                Stop();
            }
        }
        if (Input.GetKeyDown(KeyCode.I))
        {
            InfoMenuUI.SetActive(true);
        }
        else if (Input.GetKeyUp(KeyCode.I))
        {
            InfoMenuUI.SetActive(false);
        }

    }


    public void Resume()
    {
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        gameispaused = false;

    }

    void Stop()
    {
        PauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        gameispaused = true;
    }

}
