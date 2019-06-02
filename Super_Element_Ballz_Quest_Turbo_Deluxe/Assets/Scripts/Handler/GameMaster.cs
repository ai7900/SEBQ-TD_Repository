using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMaster : MonoBehaviour
{
    [SerializeField]
    private SceneFader sceneFader;

    [SerializeField]
    private string nextLevel;

    private string menuScene = "MainMenu_2.0";

    private GameObject player;

    [SerializeField]
    private float parTime;

    private PlayerStats playerStats;

    // Start is called before the first frame update
    private void Start()
    {

        sceneFader = GameObject.FindGameObjectWithTag("SceneFader").GetComponent<SceneFader>();
        Cursor.lockState = CursorLockMode.Locked;
        try
        {
            AudioManager.Play("LevelTheme");
            AudioManager.Play("Ambience");
        }
        catch(Exception e)
        {
            Debug.Log(e.Message);
        }


        playerStats = GetComponent<PlayerStats>();

    }

    // Update is called once per frame
    private void Update()
    {
        if(!player)
        {
            player = GameObject.FindWithTag("Player");
        }
    }

    //Denna metoden ska hantera vad som händer när nivån klaras av
    public void LevelCompleted(float timeSpent)
    {
        if (timeSpent < parTime)
        {
            playerStats.TimeBonus = (int)((parTime - timeSpent) * (parTime - timeSpent) * 1.35f);
        }
        else
        {
            playerStats.TimeBonus = 0;
        }
        playerStats.CalculateTotalScore();
        player.SetActive(false);
        sceneFader.StartFadeOut();
    }

    //Metod som startar om den nuvarande nivån och lägger till ett dödsfall för spelaren
    public void RestartLevel()
    {
        PlayerStats.deathCount++;
        sceneFader.FadeTo(SceneManager.GetActiveScene().name);
    }

    public void QuitToMain()
    {
        sceneFader.FadeTo(menuScene);
    }

    public void LoadNextLevel()
    {
        sceneFader.FadeTo(nextLevel);
    }
}
