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

    // Start is called before the first frame update
    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        FindObjectOfType<AudioManager>().Play("WinterTheme");
    }

    // Update is called once per frame
    private void Update()
    {
        if(!player)
        {
            player = GameObject.FindWithTag("Player");
        }
        //MouseSettings();

        if (Input.GetKeyDown(KeyCode.R))
        {
            RestartLevel();
        }
    }

    //Denna metoden ska hantera vad som händer när nivån klaras av
    public void LevelCompleted()
    {
        player.SetActive(false);
        sceneFader.FadeTo(nextLevel);
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
}
