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
    [SerializeField] private string level1;
    [SerializeField] private string level2;
    [SerializeField] private string level3;
    [SerializeField] private string level4;

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
                        sceneFader.FadeTo(level1);
                    }
                    break;

                case MenuCamera.MenuState.Continue:
                    {

                    }
                    break;

                case MenuCamera.MenuState.LevelSelect:
                    {
                        //Only runs is camera is not in main menu select
                        if (!menuCamera.MainMenu())
                        {
                            switch (menuCamera.selectedBranchView + 1)
                            {
                                case 1:
                                    sceneFader.FadeTo(level1);
                                    break;

                                case 2:
                                    sceneFader.FadeTo(level2);
                                    break;

                                case 3:
                                    sceneFader.FadeTo(level3);
                                    break;

                                case 4:
                                    sceneFader.FadeTo(level4);
                                    break;

                            }
                        }
                    }
                    break;

                case MenuCamera.MenuState.Options:
                    {

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
