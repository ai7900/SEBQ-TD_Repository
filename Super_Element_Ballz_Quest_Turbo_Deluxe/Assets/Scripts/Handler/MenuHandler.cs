using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuHandler : MonoBehaviour
{
    public MenuCamera menuCamera;
    public Text screenOptionText;           // The text in SCREEN RESOLUTION menu
    public Text soundOptionText;            // The text int SOUND OPTION menu
    private string screenText;
    private string soundText;

    private int screenSizeSelect;           // An integer that iterates by +1 everytime return is pressed changing the resolution
    private int soundVolumeSelect;          // An integer that iterates by +1 everytime return is pressed changing the resolution

    private int maxScreenSizeSelect;        // The max amount of options for ScreenSelect
    private int maxSoundVolumeSelect;       // The max amount of options for SoundSelect

    private int initResolutionWidth;
    private int initResolutionHeight;

    [SerializeField] private SceneFader sceneFader;          // A black screne-fader

    [SerializeField] private GameObject levelSelectCardsUI;
    [SerializeField] private GameObject playUI;
    [SerializeField] private GameObject levelSelectTitleUI;

    [Header("Levels in levelSelect")]
    [SerializeField] private string[] levelName;        // The names of the levels which are loaded thorugh the builder

    private void Start()
    {
        screenText = "\nWindow screen resolution\n----------------------------------\n\nPress Enter To Change\nScreen Resolution\n\nCurrent Window Resolution: ";
        soundText = "\nMaster Volume\n----------------------------------\n\nPress Enter To Change\nMaster Volume\n\nCurrent Volume: ";

        screenSizeSelect = 1;
        soundVolumeSelect = 1;
        maxScreenSizeSelect = 5;
        maxSoundVolumeSelect = 5;
        screenOptionText.text = screenText + "100%";
        soundOptionText.text = soundText + "100%";

        initResolutionWidth = Screen.currentResolution.width;
        initResolutionHeight = Screen.currentResolution.height;

        FindObjectOfType<AudioManager>().Play("WinterTheme");

    }

    // Update is called once per frame
    private void Update()
    {
        ActiveUI();

        //Lägg till funktioner för de olika menyvalen här
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Current MenuState: " + menuCamera.CurrentMenuState);
            Debug.Log("Current branch Inseption level: " + menuCamera.branchInceptionLevel);
            Debug.Log("Current selected Branch view: " + menuCamera.selectedBranchView);



            switch (menuCamera.CurrentMenuState)
            {
                case MenuCamera.MenuState.Play:
                    {
                        sceneFader.FadeTo(levelName[0]);
                    }
                    break;

                case MenuCamera.MenuState.Continue:
                    {

                    }
                    break;

                case MenuCamera.MenuState.LevelSelect:
                    {
                       
                        //Only runs is camera is not in main menu select
                        if (menuCamera.IsBranchView && menuCamera.branchInceptionLevel == 2)
                        {

                            for (int i = 0; i < menuCamera.selectedBranchView + 1; i++)
                            {
                                try
                                {
                                    if (i == menuCamera.selectedBranchView)
                                    {
                                    
                                        sceneFader.FadeTo(levelName[i]);
                                    }
                                }
                                catch(System.Exception failedToLoadScene)
                                {
                                    Debug.Log("Couldn't load scene");
                                }
                            }

                        }
                    }
                    break;

                case MenuCamera.MenuState.Options:
                    {
                        
                        if(menuCamera.branchInceptionLevel == 2)
                        {
                            //SoundControll
                            if(menuCamera.selectedBranchView == 0)
                            {
                                soundVolumeSelect++;
                                if (soundVolumeSelect >= maxSoundVolumeSelect)
                                {
                                    soundVolumeSelect = 1;
                                }

                                for (int i = 1; i < maxSoundVolumeSelect + 1; i++)
                                {
                                    if (soundVolumeSelect == i)
                                    {
                                        soundOptionText.text = soundText + (100 / i).ToString() + "%";
                                    }

                                }

                            }

                            //ScreenSize
                            else if (menuCamera.selectedBranchView == 1)
                            {
                                screenSizeSelect++;
                                if (screenSizeSelect >= maxScreenSizeSelect)
                                {
                                    screenSizeSelect = 1;
                                }

                                for (int i = 1; i < maxScreenSizeSelect + 1; i++)
                                {
                                    if (screenSizeSelect == i)
                                    {
                                        if (Screen.fullScreen)
                                        {
                                            Screen.SetResolution(initResolutionWidth / i, initResolutionHeight / i, true);
                                        }
                                        else
                                        {
                                            Screen.SetResolution(1920 / i, 1080 / i, false);
                                        }
                                        
                                        screenOptionText.text = screenText + (100 / i).ToString() + "%";
                                    }

                                }

                            }

                        }
                        
                    }
                    break;

                case MenuCamera.MenuState.Quit:
                    {
                        Debug.Log("Game Quit");
                        Application.Quit();
                    }
                    break;
            }
        }
    }

    private void ActiveUI()
    {
        //LevelSelect Cards
        if (menuCamera.CurrentMenuState == MenuCamera.MenuState.LevelSelect && menuCamera.IsBranchView)
        {
            levelSelectCardsUI.SetActive(true);
        }
        else
        {
            levelSelectCardsUI.SetActive(false);
        }

        //LevelSelect Titel
        if(menuCamera.CurrentMenuState == MenuCamera.MenuState.LevelSelect && !menuCamera.IsBranchView)
        {
            levelSelectTitleUI.SetActive(true);
        }
        else
        {
            levelSelectTitleUI.SetActive(false);
        }

        //Play Text
        if(menuCamera.CurrentMenuState == MenuCamera.MenuState.Play)
        {
            playUI.SetActive(true);
        }
        else
        {
            playUI.SetActive(false);
        }

    }
}
