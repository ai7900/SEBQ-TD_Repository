﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    [SerializeField]
    private GameMaster gameMaster;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            gameMaster.LevelCompleted();
        }
    }
}
