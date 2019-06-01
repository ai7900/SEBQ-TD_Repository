﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImpactEffect : MonoBehaviour
{
    BallMovement ballMovement;
    private void Start()
    {
        ballMovement = GetComponent<BallMovement>();
    }
    private void Update()
    {
        float volume = ballMovement.GetVolume()/20;
        AudioManager.ChangeVolume(volume, "ImpactSFX");
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.relativeVelocity.magnitude >= 5)
        {
            AudioManager.Play("ImpactSFX");
        }
    }

}