using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireCharger : MonoBehaviour
{
    private BallModeController playerMode;
    private ParticleSystem chargeParticles;

    private void Start()
    {
        chargeParticles = gameObject.GetComponentInChildren<ParticleSystem>();
        chargeParticles.Stop();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            chargeParticles.Play();
            playerMode = other.GetComponent<BallModeController>();
            playerMode.ChargingFire = true;
            playerMode.TurnIntoFireball();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerMode.ChargingFire = false;
            chargeParticles.Stop();
        }
    }
}
