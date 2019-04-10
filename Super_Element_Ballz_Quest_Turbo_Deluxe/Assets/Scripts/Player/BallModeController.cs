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
    public GameObject FireBallPrefab;

    private GameObject newObject;
 

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
            newObject = Instantiate(FireBallPrefab, gameObject.transform.position, gameObject.transform.rotation);
            newObject.GetComponent<Rigidbody>().velocity = gameObject.GetComponent<Rigidbody>().velocity;
            Destroy(gameObject);
        }

    }
}
