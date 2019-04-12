using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuHandler : MonoBehaviour
{
    public MenuCamera menuCamera;

    [SerializeField]
    private string firstLevel;


    // Start is called before the first frame update
    void Start()
    {

    }

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
                        //Vi använder sceneFader här sen!
                        SceneManager.LoadScene(firstLevel);
                    }
                    
                    break;

                case MenuCamera.MenuState.Continue:
                    {

                    }
                    break;

                case MenuCamera.MenuState.Level_Select:
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
            

        //if(Input.GetKeyDown(KeyCode.Return))
        //{
        //    if(menuCamera.CurrentMenuState == MenuCamera.MenuState.Play)
        //    {
                
        //    }

        //    else if (menuCamera.CurrentMenuState == MenuCamera.MenuState.Continue)
        //    {

        //    }

        //    else if (menuCamera.CurrentMenuState == MenuCamera.MenuState.Level_Select)
        //    {

        //    }

        //    else if (menuCamera.CurrentMenuState == MenuCamera.MenuState.Options)
        //    {

        //    }

        //    else if (menuCamera.CurrentMenuState == MenuCamera.MenuState.Quit)
        //    {

        //    }
        //}
    }
}
