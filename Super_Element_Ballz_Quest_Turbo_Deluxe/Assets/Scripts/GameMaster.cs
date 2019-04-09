using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : MonoBehaviour
{
    [Header("Mouse settings")]
    public bool showMouseCursor = false;
    public bool lockMouseCursor = false;

    // Start is called before the first frame update
    private void Start()
    {

        
    }

    // Update is called once per frame
    private void Update()
    {
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
    }
}
