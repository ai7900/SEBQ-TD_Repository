using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuHandler : MonoBehaviour
{
    public MenuCamera menuCamera;

    [SerializeField]
    private SceneFader sceneFader;

    [Header("Levels in levelSelect")]
    [SerializeField] private string[] levelName;

    // Update is called once per frame
    void Update()
    {

        //Lägg till funktioner för de olika menyvalen här
        if(Input.GetKeyDown(KeyCode.Return))
        {
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
                            
                            for(int i = 0; i < menuCamera.selectedBranchView + 1; i++)
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
                        Screen.SetResolution(640, 480, false);
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
}
