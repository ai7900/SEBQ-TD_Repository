using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDirectionHelper : MonoBehaviour
{
    [SerializeField]
    private GameObject playerCamera;

    private Transform rotation;

    // Start is called before the first frame update
    void Start()
    {
        rotation = GetComponent<Transform>();
        
    }

    // Update is called once per frame
    void Update()
    {
        playerCamera = GameObject.FindGameObjectWithTag("MainCamera");
        rotation.transform.eulerAngles = new Vector3(0, playerCamera.transform.eulerAngles.y, 0);
    }
}
