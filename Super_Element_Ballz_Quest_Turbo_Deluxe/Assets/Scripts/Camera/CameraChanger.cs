using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChanger : MonoBehaviour
{
    [SerializeField]
    [Header("Camera Settings")]
    private Camera adjustCamera;
    [SerializeField]
    private Camera adjustCameraThirdPerson;

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            adjustCamera.enabled = false;
            adjustCameraThirdPerson.enabled = true;
            adjustCamera.orthographic = false;
        }

        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            adjustCamera.enabled = true;
            adjustCameraThirdPerson.enabled = false;
            adjustCamera.orthographic = true;
            adjustCamera.orthographicSize = 20;
        }

        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            adjustCamera.enabled = false;
            adjustCameraThirdPerson.enabled = true;
            adjustCamera.orthographic = false;
        }
    }
}
