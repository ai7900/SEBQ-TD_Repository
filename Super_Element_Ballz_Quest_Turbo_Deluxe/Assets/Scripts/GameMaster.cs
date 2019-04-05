using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : MonoBehaviour
{
    [Header("Mouse settings")]
    public bool showMouseCursor = false;

    [SerializeField]
    GameObject levelWonUI;

    // Start is called before the first frame update
    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    private void Update()
    {
        Cursor.visible = showMouseCursor;
    }

    public void LevelCompleted()
    {
        levelWonUI.SetActive(true);
    }
}
