using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    [SerializeField]
    private GameMaster gameMaster;

    private bool isLevelComplete = false;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            try
            {
                if(isLevelComplete == false)
                {
                    gameMaster.LevelCompleted(UiHandler.timeSpent);
                    isLevelComplete = true;
                }
            }
            catch(Exception e)
            {
                Debug.Log(e.Message);
            }
        }
    }
}
