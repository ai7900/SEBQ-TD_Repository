﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireCharger : MonoBehaviour
{
    BallModeController playerMode;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            playerMode = other.GetComponent<BallModeController>();
            playerMode.TurnIntoFireball();
            playerMode.ChargingFire = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerMode.ChargingFire = false;
        }
    }
}
