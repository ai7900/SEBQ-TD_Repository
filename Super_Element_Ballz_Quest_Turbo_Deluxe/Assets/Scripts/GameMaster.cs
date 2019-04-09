using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : MonoBehaviour
{
    [Header("Mouse settings")]
    public bool showMouseCursor = false;
<<<<<<< HEAD

    [SerializeField]
    GameObject levelWonUI;
=======
    public bool lockMouseCursor = false;
>>>>>>> PlayerMovementCameraFix

    // Start is called before the first frame update
    private void Start()
    {
<<<<<<< HEAD
        Cursor.lockState = CursorLockMode.Locked;
=======

        
>>>>>>> PlayerMovementCameraFix
    }

    // Update is called once per frame
    private void Update()
    {
<<<<<<< HEAD
        Cursor.visible = showMouseCursor;
    }

    public void LevelCompleted()
    {
        levelWonUI.SetActive(true);
=======
        MouseSettings();

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
>>>>>>> PlayerMovementCameraFix
    }
}
