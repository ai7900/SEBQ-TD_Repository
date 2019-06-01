using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PausMenu : MonoBehaviour
{
    public static bool pausedGame;
    [SerializeField]
    private GameObject pauseMenuUi;
    
    
    private void Start()
    {
        pausedGame = false;
        pauseMenuUi.SetActive(false);
    }

    private void Update()
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
    public void Resume()
    {
        pauseMenuUi.SetActive(false);
        AudioManager.Play("UnPauseSFX");
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        Time.timeScale = 1f;
        pausedGame = false;
    }

    private void Pause()
    {
        pauseMenuUi.SetActive(true);
        AudioManager.Play("PauseSFX");
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        Time.timeScale = 0f;
        pausedGame = true;
    }
}
