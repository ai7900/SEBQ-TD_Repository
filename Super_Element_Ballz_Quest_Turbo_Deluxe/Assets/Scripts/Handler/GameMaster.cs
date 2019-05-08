using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMaster : MonoBehaviour
{
    [Header("Mouse settings")]
    public bool showMouseCursor = false;

    public bool lockMouseCursor = false;

    [SerializeField]
    private SceneFader sceneFader;

    [SerializeField]
    private string nextLevel;

    private GameObject player;

    // Start is called before the first frame update
    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    private void Update()
    {
        if(!player)
        {
            player = GameObject.FindWithTag("Player");
        }
        MouseSettings();

        if(Input.GetKeyDown(KeyCode.R))
        {
            PlayerStats.deathCount++;
            sceneFader.FadeTo(SceneManager.GetActiveScene().name);
        }
    }

    //Denna metoden ska hantera vad som händer när nivån klaras av
    public void LevelCompleted()
    {
        player.SetActive(false);
        sceneFader.FadeTo(nextLevel);
    }

    private void MouseSettings()
    {
        Cursor.visible = showMouseCursor;

        if (lockMouseCursor == true)
        {
            Cursor.lockState = CursorLockMode.Locked;
        }
        else
        {
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
