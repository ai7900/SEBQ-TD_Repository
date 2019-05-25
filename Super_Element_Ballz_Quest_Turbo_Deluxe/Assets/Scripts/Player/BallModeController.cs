using System.Collections;
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

    private int secondsParticleDestory = 3;

    public bool IceReady { get; set; } = false;
    public bool ChargingFire { get; set; } = false;
    public bool ChargingIce { get; set; } = false;

    [HideInInspector]
    public int fireChargeTime;
    [HideInInspector]
    public int fireDuration;
    [HideInInspector]
    public int iceChargeTime;
    [HideInInspector]
    public int iceDuration;

    private Quaternion iceCubeRotation = Quaternion.Euler(0,0,0);
    private Quaternion particleRotation = Quaternion.Euler(0, 0, 0);

    [SerializeField]
    private int iceInitialSpeedBoost = 70;

    private void Start()
    {
        fireChargeTime = 5; //Preliminärt värde
        fireDuration = 10; //Preliminärt värde
        iceChargeTime = 5; //Preliminärt värde
        iceDuration = 15; //Preliminärt värde
}

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Keypad1))//Normal boll
        {
            if(PlayerStats.currentMode != (int)BallMode.Normal)
            {
                newParticle = Instantiate(normalBallEffect, gameObject.transform.position, particleRotation);
                Destroy(newParticle, 5);
                TurnIntoNormalBall();
            }
        }

        if (Input.GetKeyDown(KeyCode.Keypad2))//Tung boll
        {
            if(PlayerStats.heavyFormCount > 0 && PlayerStats.currentMode != (int)BallMode.Heavy)
            {
                FindObjectOfType<AudioManager>().Play("TransformStoneSFX");
                newParticle = Instantiate(heavyBallEffect, gameObject.transform.position, particleRotation);
                Destroy(newParticle, 5);
                TurnIntoHeavyBall();
            }
        }

        if (Input.GetKeyDown(KeyCode.Keypad3) && PlayerStats.currentMode != (int)BallMode.Light)//Lätt boll
        {
            if(PlayerStats.lightFormCount > 0)
            {
                FindObjectOfType<AudioManager>().Play("TransformAirSFX");
                newParticle = Instantiate(lightBallEffect, gameObject.transform.position, particleRotation);
                Destroy(newParticle, 5);
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
            Destroy(newParticle, 5);
            TurnIntoFireball();
        }

        if (newParticle != null)
        {
            newParticle.transform.SetParent(newObject.transform);
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

}
