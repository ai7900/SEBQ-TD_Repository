﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity;
using UnityEditor;

[System.Serializable]
public class BallModeController : MonoBehaviour
{
    public GameObject normalBallPrefab;
    public GameObject heavyBallPrefab;
    public GameObject lightBallPrefab;
    public GameObject fireBallPrefab;
    public GameObject iceCubePrefab;

    public ParticleSystem heavyBallEffect;
    public ParticleSystem lightBallEffect;
    public ParticleSystem fireballEffect;
    public ParticleSystem normalBallEffect;

    private GameObject newObject;
    private ParticleSystem newParticle;

    public bool IceReady { get; set; } = false;
    public bool ChargingFire { get; set; } = false;
    public bool ChargingIce { get; set; } = false;

    [HideInInspector]
    public int fireChargeTime = 5; //Preliminärt värde
    [HideInInspector]
    public int fireDuration = 10; //Preliminärt värde
    [HideInInspector]
    public int iceChargeTime = 5; //Preliminärt värde
    [HideInInspector]
    public int iceDuration = 15; //Preliminärt värde

    private Quaternion iceCubeRotation = Quaternion.Euler(0,0,0);
    private Quaternion particleRotation = Quaternion.Euler(0, 0, 0);

    [SerializeField]
    private int iceInitialSpeedBoost = 70;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Keypad1))//Normal boll
        {
            if(PlayerStats.currentMode != (int)BallMode.Normal)
            {
                newParticle = Instantiate(normalBallEffect, gameObject.transform.position, particleRotation);
                TurnIntoNormalBall();
            }
        }

        if (Input.GetKeyDown(KeyCode.Keypad2))//Tung boll
        {
            if(PlayerStats.heavyFormCount > 0 && PlayerStats.currentMode != (int)BallMode.Heavy)
            {
                newParticle = Instantiate(heavyBallEffect, gameObject.transform.position, particleRotation);
                TurnIntoHeavyBall();
            }
        }

        if (Input.GetKeyDown(KeyCode.Keypad3) && PlayerStats.currentMode != (int)BallMode.Light)//Lätt boll
        {
            if(PlayerStats.lightFormCount > 0)
            {
                newParticle = Instantiate(lightBallEffect, gameObject.transform.position, particleRotation);
                TurnIntoLightBall();
            }
        }

        if (Input.GetKeyDown(KeyCode.Keypad4))  //Kall boll
        {
            if(PlayerStats.currentMode != (int)BallMode.Ice && IceReady)
            {
                TurnIntoIcecube();
            }
            
        }

        if (Input.GetKeyDown(KeyCode.Keypad5))//DEBUG ONLY
        {
            newParticle = Instantiate(fireballEffect, gameObject.transform.position, particleRotation);
            TurnIntoFireball();
        }

    }

    private void LateUpdate()
    {
        if (newParticle != null)
        {
            newParticle.transform.position = gameObject.transform.position;
            DestroyParticle(newParticle);
        }
    }

    public void TurnIntoNormalBall()
    {
        newObject = Instantiate(normalBallPrefab, gameObject.transform.position, gameObject.transform.rotation);
        newObject.GetComponent<Rigidbody>().velocity = gameObject.GetComponent<Rigidbody>().velocity;

        PlayerStats.currentMode = (int) BallMode.Normal;
        Destroy(gameObject);
    }
    
    private void TurnIntoHeavyBall()
    {
        newObject = Instantiate(heavyBallPrefab, gameObject.transform.position, gameObject.transform.rotation);
        newObject.GetComponent<Rigidbody>().velocity = gameObject.GetComponent<Rigidbody>().velocity;

        PlayerStats.currentMode = (int)BallMode.Heavy;
        PlayerStats.heavyFormCount--;
        Destroy(gameObject);
    }

    private void TurnIntoLightBall()
    {
        newObject = Instantiate(lightBallPrefab, gameObject.transform.position, gameObject.transform.rotation);
        newObject.GetComponent<Rigidbody>().velocity = gameObject.GetComponent<Rigidbody>().velocity;

        PlayerStats.currentMode = (int)BallMode.Light;
        PlayerStats.lightFormCount--;
        Destroy(gameObject);
    }

    public void TurnIntoFireball()
    {
        if(PlayerStats.currentMode != (int)BallMode.Fire)
        {
            newObject = Instantiate(fireBallPrefab, gameObject.transform.position, gameObject.transform.rotation);
            newObject.GetComponent<Rigidbody>().velocity = gameObject.GetComponent<Rigidbody>().velocity;

            newObject.GetComponent<BallModeController>().ChargingFire = ChargingFire;
            PlayerStats.currentMode = (int)BallMode.Fire;
            Destroy(gameObject);
        }
    }

    public void TurnIntoIcecube()
    {
        newObject = Instantiate(iceCubePrefab, gameObject.transform.position, iceCubeRotation);
        Rigidbody rb = newObject.GetComponent<Rigidbody>();
        rb.velocity = gameObject.GetComponent<Rigidbody>().velocity;

        PlayerStats.currentMode = (int)BallMode.Ice;
        Destroy(gameObject);
    }

    private void DestroyParticle(ParticleSystem particle)
    {

        if (!particle.IsAlive())
        {
            Destroy(gameObject);
        }

    }

}
