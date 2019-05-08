using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDirectionHelper : MonoBehaviour
{
    [SerializeField]
    private GameObject playerCamera;
    [SerializeField]
    private Camera isoCamera;
    [SerializeField]
    private Camera thirdCamera;
    private Transform rotation;

    // Start is called before the first frame update
    void Start()
    {
        rotation = GetComponent<Transform>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isoCamera.enabled == true)
        {
            playerCamera = GameObject.FindGameObjectWithTag("MainCamera");
        }
        else if (thirdCamera.enabled)
        {
            playerCamera = GameObject.FindGameObjectWithTag("ThirdPersonCamera");
        }

        rotation.transform.eulerAngles = new Vector3(0, playerCamera.transform.eulerAngles.y, 0);
    }
}
