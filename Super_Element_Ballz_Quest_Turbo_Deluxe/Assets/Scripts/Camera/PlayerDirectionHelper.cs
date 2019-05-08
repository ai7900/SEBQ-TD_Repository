using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDirectionHelper : MonoBehaviour
{
    [SerializeField]
    private GameObject playerCamera;
    private GameObject isoCameraGO;
    private GameObject thirdCameraGO;
    [SerializeField]
    private Camera isoCamera;
    [SerializeField]
    private Camera thirdCamera;
    private Transform rotation;

    // Start is called before the first frame update
    void Start()
    {
        rotation = GetComponent<Transform>();
        isoCameraGO = GameObject.FindGameObjectWithTag("MainCamera");
        thirdCameraGO = GameObject.FindGameObjectWithTag("ThirdPersonCamera");
        isoCamera = isoCameraGO.GetComponent<Camera>();
        thirdCamera = thirdCameraGO.GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        if(isoCamera.enabled)
        {
            playerCamera = isoCameraGO;
        }
        else if (thirdCamera.enabled)
        {
            playerCamera = thirdCameraGO;
        }

        rotation.transform.eulerAngles = new Vector3(0, playerCamera.transform.eulerAngles.y, 0);
    }
}
