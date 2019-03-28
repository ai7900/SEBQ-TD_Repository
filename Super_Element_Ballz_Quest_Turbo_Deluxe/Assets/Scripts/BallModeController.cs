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


    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(normalBallPrefab, gameObject.transform.position, gameObject.transform.rotation);
            Destroy(gameObject);
        }

        else if (Input.GetButtonDown("Fire2"))
        {
            Instantiate(heavyBallPrefab, gameObject.transform.position, gameObject.transform.rotation);
            Destroy(gameObject);
        }

        else if (Input.GetButtonDown("Fire3"))
        {
            Instantiate(lightBallPrefab, gameObject.transform.position, gameObject.transform.rotation);
            Destroy(gameObject);
        }

    }
}
