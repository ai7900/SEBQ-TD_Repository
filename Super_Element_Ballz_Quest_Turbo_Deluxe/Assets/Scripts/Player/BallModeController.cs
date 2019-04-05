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

    private GameObject newObject;
 

    void Update()
    {

        if (Input.GetButtonDown("Fire1"))
        {
            
            newObject=Instantiate(normalBallPrefab, gameObject.transform.position, gameObject.transform.rotation);
            newObject.GetComponent<Rigidbody>().velocity = gameObject.GetComponent<Rigidbody>().velocity;
            Destroy(gameObject);
        }

        else if (Input.GetButtonDown("Fire2"))
        {
            newObject = Instantiate(heavyBallPrefab, gameObject.transform.position, gameObject.transform.rotation);
            newObject.GetComponent<Rigidbody>().velocity = gameObject.GetComponent<Rigidbody>().velocity;
            Destroy(gameObject);
        }

        else if (Input.GetButtonDown("Fire3"))
        {
            newObject = Instantiate(lightBallPrefab, gameObject.transform.position, gameObject.transform.rotation);
            newObject.GetComponent<Rigidbody>().velocity = gameObject.GetComponent<Rigidbody>().velocity;
            Destroy(gameObject);
        }

    }
}
