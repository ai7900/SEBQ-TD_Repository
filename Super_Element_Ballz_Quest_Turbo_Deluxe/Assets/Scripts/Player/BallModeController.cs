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
 

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Keypad1))
        {
            
            newObject=Instantiate(normalBallPrefab, gameObject.transform.position, gameObject.transform.rotation);
            newObject.GetComponent<Rigidbody>().velocity = gameObject.GetComponent<Rigidbody>().velocity;
            Destroy(gameObject);
        }

        else if (Input.GetKeyDown(KeyCode.Keypad2))
        {
            newObject = Instantiate(heavyBallPrefab, gameObject.transform.position, gameObject.transform.rotation);
            newObject.GetComponent<Rigidbody>().velocity = gameObject.GetComponent<Rigidbody>().velocity;
            Destroy(gameObject);
        }

        else if (Input.GetKeyDown(KeyCode.Keypad3))
        {
            newObject = Instantiate(lightBallPrefab, gameObject.transform.position, gameObject.transform.rotation);
            newObject.GetComponent<Rigidbody>().velocity = gameObject.GetComponent<Rigidbody>().velocity;
            Destroy(gameObject);
        }

        else if (Input.GetKeyDown(KeyCode.Keypad4))
        {
            newObject = Instantiate(fireBallPrefab, gameObject.transform.position, gameObject.transform.rotation);
            newObject.GetComponent<Rigidbody>().velocity = gameObject.GetComponent<Rigidbody>().velocity;
            Destroy(gameObject);
        }

        else if (Input.GetKeyDown(KeyCode.Keypad5))
        {
            newObject = Instantiate(iceCubePrefab, gameObject.transform.position, iceCubeRotation);
            newObject.GetComponent<Rigidbody>().velocity = gameObject.GetComponent<Rigidbody>().velocity;
            Destroy(gameObject);
        }

    }
}
