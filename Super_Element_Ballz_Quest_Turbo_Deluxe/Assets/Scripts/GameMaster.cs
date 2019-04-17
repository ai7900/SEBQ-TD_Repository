using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : MonoBehaviour
{
    [Header("Mouse settings")]
    public bool showMouseCursor = false;

    [SerializeField]
    GameObject levelWonUI;
    public bool lockMouseCursor = false;

    // Start is called before the first frame update
    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    private void Update()
    {
        MouseSettings();
    }

    //Denna metoden ska hantera vad som händer när nivån klaras av
    public void LevelCompleted()
    {
        levelWonUI.SetActive(true);
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
