using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This script handles the momvement of the camera
/// </summary>
public class MenuCamera : MonoBehaviour
{
    public enum MenuState {Play = 0, Continue, LevelSelect, Options, Quit};
    public MenuState CurrentMenuState { get; private set; }
    public bool MainMenu() { return isMainMenu; }

    public int selectedBranchView;

    [SerializeField]
    [Range(0.01f, 10f)]
    private float transitionSpeed;
    private Transform currentViewTransform;
    private Vector3 currentAngle;

    [Header("Checkpoints for camera")]
    public Transform[] mainViews;
    public Transform[] levelSelectViews;
    public Transform[] optionSelectViews;
    public Transform[] quitGameViews;

    private Transform[] branchMenuViews;

    private bool isMainMenu;

    // Start is called before the first frame update
    private void Start()
    {
        isMainMenu = true;
        currentViewTransform = mainViews[(int)MenuState.Play];
    }

    private void Update()
    {

        // Every menu except the play menu has more views for the camera
        if ((Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W)) && CurrentMenuState != (int)MenuState.Play)
        {
            isMainMenu = false;
            selectedBranchView = 0;

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

        if (isMainMenu)
        {
            MainMenuControll();
        }
        else
        {
            BranchMenuSelect(branchMenuViews);
        }

    }

    /// <summary>
    /// Initiates SmoothRotateToNewPos and SmoothMovementToNewPos every frame
    /// It knows which views to select
    /// </summary>
    private void LateUpdate()
    {
        if (isMainMenu)
        {
            currentViewTransform = mainViews[(int)CurrentMenuState];
        }
        else
        {
            currentViewTransform = branchMenuViews[selectedBranchView];
        }

        SmoothMovementToNewPos();
        SmoothRotateToNewPos();
    }

    /// <summary>
    /// Controller for branch menu
    /// </summary>
    /// <param name="viewSelect">The branchMenuView</param>
    private void BranchMenuSelect(Transform[] viewSelect)
    {
        if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))
        {
            if(selectedBranchView < viewSelect.Length - 1)
            {
                selectedBranchView++;
            }
            
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A))
        {
            if(selectedBranchView > 0)
            {
                selectedBranchView--;
            }
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S))
        {
            isMainMenu = true;
        }
    }

    /// <summary>
    /// Controller for mainMenu
    /// </summary>
    private void MainMenuControll()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A))
        {
            CurrentMenuState--;
            if (CurrentMenuState < 0)
            {
                CurrentMenuState = MenuState.Quit;
            }
        }

        if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))
        {
            CurrentMenuState++;
            if ((int)CurrentMenuState == mainViews.Length)
            {
                CurrentMenuState = MenuState.Play;
            }
        }
    }

    /// <summary>
    /// Rotates the camera
    /// </summary>
    private void SmoothRotateToNewPos()
    {
        currentAngle = new Vector3(
                   Mathf.LerpAngle(transform.rotation.eulerAngles.x, currentViewTransform.eulerAngles.x, Time.deltaTime * transitionSpeed),
                   Mathf.LerpAngle(transform.rotation.eulerAngles.y, currentViewTransform.eulerAngles.y, Time.deltaTime * transitionSpeed),
                   Mathf.LerpAngle(transform.rotation.eulerAngles.z, currentViewTransform.eulerAngles.z, Time.deltaTime * transitionSpeed));

        transform.eulerAngles = currentAngle;
    }

    /// <summary>
    /// Uses linjear interpolation to smoothly move the camera for one position to the next
    /// </summary>
    private void SmoothMovementToNewPos()
    {
        transform.position = Vector3.Lerp(transform.position, currentViewTransform.position, transitionSpeed * Time.deltaTime);
    }

    /// <summary>
    /// Debugging
    /// </summary>
    private void OnGUI()
    {
        GUI.Label(new Rect(20, Screen.height - 30, 200, 200), "Current state = " + CurrentMenuState.ToString());
    }
}
