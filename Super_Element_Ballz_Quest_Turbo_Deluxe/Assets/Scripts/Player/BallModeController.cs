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

    private Quaternion iceCubeRotation = Quaternion.Euler(0,0,0);

    [SerializeField]
    private int iceInitialSpeedBoost = 70;
 
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Keypad1))//Normal boll
        {           
            newObject = Instantiate(normalBallPrefab, gameObject.transform.position, gameObject.transform.rotation);
            newObject.GetComponent<Rigidbody>().velocity = gameObject.GetComponent<Rigidbody>().velocity;
            PlayerStats.currentMode = (int)BallMode.Normal; 
            Destroy(gameObject);
        }

        else if (Input.GetKeyDown(KeyCode.Keypad2))//Tung boll
        {
            if(PlayerStats.heavyFormCount > 0)
            {
                newObject = Instantiate(heavyBallPrefab, gameObject.transform.position, gameObject.transform.rotation);
                newObject.GetComponent<Rigidbody>().velocity = gameObject.GetComponent<Rigidbody>().velocity;
                PlayerStats.currentMode = (int)BallMode.Heavy;
                PlayerStats.heavyFormCount--;
                Destroy(gameObject);
            }
        }

        else if (Input.GetKeyDown(KeyCode.Keypad3))//Lätt boll
        {
            if(PlayerStats.lightFormCount > 0)
            {
                newObject = Instantiate(lightBallPrefab, gameObject.transform.position, gameObject.transform.rotation);
                newObject.GetComponent<Rigidbody>().velocity = gameObject.GetComponent<Rigidbody>().velocity;
                PlayerStats.currentMode = (int)BallMode.Light;
                PlayerStats.lightFormCount--;
                Destroy(gameObject);
            }
        }

        else if (Input.GetKeyDown(KeyCode.Keypad4))//Eldboll
        {
            newObject = Instantiate(fireBallPrefab, gameObject.transform.position, gameObject.transform.rotation);
            newObject.GetComponent<Rigidbody>().velocity = gameObject.GetComponent<Rigidbody>().velocity;
            PlayerStats.currentMode = (int)BallMode.Fire;
            Destroy(gameObject);
        }

        else if (Input.GetKeyDown(KeyCode.Keypad5))//Iskub
        {
            newObject = Instantiate(iceCubePrefab, gameObject.transform.position, iceCubeRotation);
            Rigidbody rb = newObject.GetComponent<Rigidbody>();
            rb.velocity = gameObject.GetComponent<Rigidbody>().velocity;
            PlayerStats.currentMode = (int)BallMode.Ice;
            Destroy(gameObject);
        }

    }
}
