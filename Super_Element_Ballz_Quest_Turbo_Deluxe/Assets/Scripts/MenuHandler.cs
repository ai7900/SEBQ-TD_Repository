using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuHandler : MonoBehaviour
{
    public MenuCamera menuCamera;

    [SerializeField]
    private SceneFader sceneFader;

    [SerializeField]
    private string firstLevel;

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
                        sceneFader.FadeTo(firstLevel);
                    }
                    break;

                case MenuCamera.MenuState.Continue:
                    {

                    }
                    break;

                case MenuCamera.MenuState.LevelSelect:
                    {

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
