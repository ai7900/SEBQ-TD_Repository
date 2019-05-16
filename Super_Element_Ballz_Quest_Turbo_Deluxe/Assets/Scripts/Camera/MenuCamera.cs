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
    public bool IsBranchView { get { return branchView; } }                         // Is used in MenuHandler
    public int branchInceptionLevel;                                                // The level of depth the user is in menus

    public int selectedBranchView;                                                  // Similar to an Enum when selection options from branchViews

    [SerializeField]
    [Range(0.01f, 10f)]
    private float transitionSpeed;                                                  // The lerp-speed of the camera
    private Transform currentViewTransform;                                         // The cameras current transform
    private Vector3 currentAngle;                                                   // The cameras current angle

    [Header("Checkpoints for camera")]
    public Transform[] mainViews;                                                   // The main menu's views
    public Transform[] levelSelectViews;                                            // The level-select's views
    public Transform[] optionSelectViews;                                           // The options-menu's views
    public Transform[] quitGameViews;                                               // The quitGame's views

    private Transform[] branchMenuViews;                                            // A placeholder for branchMenu views used to copy the branch views

    private bool branchView;

    private void Start()
    {
        branchView = false;
        branchInceptionLevel = 0;

        currentViewTransform = mainViews[(int)MenuState.Play];
    }

    private void Update()
    {

        // Every menu except the play menu has more views for the camera
        if (Input.GetKeyDown(KeyCode.Return) && CurrentMenuState != MenuState.Play && CurrentMenuState != MenuState.Quit)
        {
            branchView = true;
            if(branchInceptionLevel == 0)
            {
                selectedBranchView = 0;
            }
            branchInceptionLevel++;

            switch (CurrentMenuState)
            {
                case MenuState.Options:
                    branchMenuViews = optionSelectViews;
                    branchInceptionLevel = InceptionLevelCap(branchInceptionLevel, 2);
                    break;

                case MenuState.LevelSelect:
                    branchMenuViews = levelSelectViews;
                    branchInceptionLevel = InceptionLevelCap(branchInceptionLevel, 2);

                    break;
            }
        }

        if (!branchView)
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
        if (!branchView)
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
        else if (Input.GetKeyDown(KeyCode.Backspace))
        {
            branchView = false;
            branchInceptionLevel = 0;
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

    /// <summary>
    /// Caps the inceptionLevel
    /// </summary>
    /// <param name="currentInceptionLevel">The current inceptionLevel</param>
    /// <param name="cap">The cap of inceptionLevel</param>
    /// <returns></returns>
    private int InceptionLevelCap(int currentInceptionLevel, int cap)
    {
        if(currentInceptionLevel >= cap)
        {
            currentInceptionLevel = cap;
        }

        return currentInceptionLevel;
    }
}
