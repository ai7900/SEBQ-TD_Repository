using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PausMenu : MonoBehaviour
{
    public static bool pausedGame;
    [SerializeField]
    private GameObject pauseMenuUi;
    void Start()
    {
        pausedGame = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (pausedGame)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }
    private void Resume()
    {
        pauseMenuUi.SetActive(false);
        Time.timeScale = 1f;
        pausedGame = false;
    }

    private void Pause()
    {
        pauseMenuUi.SetActive(true);
        Time.timeScale = 0f;
        pausedGame = true;
    }
}
