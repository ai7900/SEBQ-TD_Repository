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

    private GameObject newObject;

    public bool ChargingFire { get; set; } = false;
    public bool ChargingIce { get; set; } = false;

    [HideInInspector]
    public int fireChargeTime = 5; //Preliminärt värde
    [HideInInspector]
    public int fireDuration = 10; //Preliminärt värde

    private Quaternion iceCubeRotation = Quaternion.Euler(0,0,0);

    [SerializeField]
    private int iceInitialSpeedBoost = 70;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Keypad1))//Normal boll
        {
            if(PlayerStats.currentMode != (int)BallMode.Normal)
            {
                TurnIntoNormalBall();
            }
        }

        if (Input.GetKeyDown(KeyCode.Keypad2))//Tung boll
        {
            if(PlayerStats.heavyFormCount > 0 && PlayerStats.currentMode != (int)BallMode.Heavy)
            {
                TurnIntoHeavyBall();
            }
        }

        if (Input.GetKeyDown(KeyCode.Keypad3) && PlayerStats.currentMode != (int)BallMode.Light)//Lätt boll
        {
            if(PlayerStats.lightFormCount > 0)
            {
                TurnIntoLightBall();
            }
        }

        if (Input.GetKeyDown(KeyCode.Keypad4))
        {
            if(PlayerStats.currentMode != (int)BallMode.Ice)
            {
                TurnIntoIcecube();
            }
            
        }

        if (Input.GetKeyDown(KeyCode.Keypad5))//DEBUG ONLY
        {
            TurnIntoFireball();
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
