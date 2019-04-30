using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuCamera : MonoBehaviour
{
    public enum MenuState {Play = 0, Continue, LevelSelect, Options, Quit};

    [SerializeField]
    [Range(0.01f, 10f)]
    private float transitionSpeed;

    [Header("Checkpoints for camera")]
    public Transform[] mainViews;
    public Transform[] levelSelectViews;
    public Transform[] optionSelectViews;
    public Transform[] quitGameViews;

    public Transform[] branchMenuViews;

    private Transform currentViewTransform;
    private Vector3 currentAngle;

    public MenuState CurrentMenuState { get; private set; }

    private bool mainMenuSelect;

    // Start is called before the first frame update
    private void Start()
    {
        mainMenuSelect = true;
        currentViewTransform = mainViews[(int)MenuState.Play];
    }

    private void Update()
    {

        // Every menu except the play menu has more views for the camera
        if (Input.GetKeyDown(KeyCode.Return) && CurrentMenuState != (int)MenuState.Play)
        {
            mainMenuSelect = false;

            switch (CurrentMenuState)
            {
                case MenuState.Options:
                    branchMenuViews = optionSelectViews;
                    break;

                case MenuState.LevelSelect:
                    branchMenuViews = levelSelectViews;
                    break;

                case MenuState.Quit:
                    branchMenuViews = quitGameViews;
                    break;
            }
        }

        if (mainMenuSelect)
        {
            MainMenuControll();
        }
        else
        {
            BranchMenuSelect();
        }

    }

    private void BranchMenuSelect()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {

        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {

        }
        else if (Input.GetKeyDown(KeyCode.Escape))
        {
            mainMenuSelect = true;
        }
    }

    private void MainMenuControll()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            CurrentMenuState--;
            if (CurrentMenuState < 0)
            {
                CurrentMenuState = MenuState.Quit;
            }
        }

        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            CurrentMenuState++;
            if ((int)CurrentMenuState == mainViews.Length)
            {
                CurrentMenuState = MenuState.Play;
            }
        }
    }

    // Update is called once per frame
    private void LateUpdate()
    {
        currentViewTransform = mainViews[(int)CurrentMenuState];
        SmoothMovementToNewPos();
        SmoothRotateToNewPos();
    }

    private void SmoothRotateToNewPos()
    {
        currentAngle = new Vector3(
                   Mathf.LerpAngle(transform.rotation.eulerAngles.x, currentViewTransform.eulerAngles.x, Time.deltaTime * transitionSpeed),
                   Mathf.LerpAngle(transform.rotation.eulerAngles.y, currentViewTransform.eulerAngles.y, Time.deltaTime * transitionSpeed),
                   Mathf.LerpAngle(transform.rotation.eulerAngles.z, currentViewTransform.eulerAngles.z, Time.deltaTime * transitionSpeed));

        transform.eulerAngles = currentAngle;
    }

    private void SmoothMovementToNewPos()
    {
        transform.position = Vector3.Lerp(transform.position, currentViewTransform.position, transitionSpeed * Time.deltaTime);
    }

    private void OnGUI()
    {
        GUI.Label(new Rect(20, Screen.height - 30, 200, 200), "Current state = " + CurrentMenuState.ToString());
    }
}
