using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Kan användas till main menu också
public class CameraController : MonoBehaviour
{
    [SerializeField]
    [Header("ChildFollow")]
    private GameObject child;

    [SerializeField]
    [Header("Camera Settings")]
    private Camera adjustCamera;

    [SerializeField]
    [Range(0.01f, 10f)]
    private float transitionSpeedIsometric;

    [SerializeField]
    [Range(0.01f, 10f)]
    private float transitionSpeedThridPerson;

    [SerializeField]
    private float rotationSpeed = 1f;

    [Header("Checkpoints for camera")]
    public Transform[] views;

    private Transform currentView;
    private Vector3 currentAngle;
    private Vector3 viewOffset = new Vector3(10f, 10f, 3f);

    //private float minRotationX = 1;
    //private float maxRotationX = 180;

    private void Start()
    {
        currentView = views[0];
        //adjustCamera.orthographic = true;
        //adjustCamera.orthographicSize = 20;
    }

    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            currentView = views[0]; //thirdperson
            adjustCamera.orthographic = false;
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            currentView = views[1]; //isometric
            adjustCamera.orthographic = true;
            adjustCamera.orthographicSize = 20;
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            currentView = views[2]; //SpecialView
            adjustCamera.orthographic = false;
        }
    }

    private void LateUpdate()
    {

        //Lerp position
        if(currentView == views[0])
        {
            transform.position = Vector3.Lerp(transform.position, currentView.position + viewOffset, transitionSpeedThridPerson * Time.deltaTime);
        }

        if(currentView == views[1] || currentView == views[2])
        {
            transform.position = Vector3.Lerp(transform.position, currentView.position, transitionSpeedIsometric * Time.deltaTime);
        }

        CameraRotation();
    }

    private void CameraRotation()
    {
        if (currentView == views[0])
        {
            Quaternion XcamTurnAngle = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * rotationSpeed, Vector3.up);
            Quaternion YcamTurnAngle = Quaternion.AngleAxis(Input.GetAxis("Mouse Y") * rotationSpeed, Vector3.left);

            viewOffset = XcamTurnAngle * viewOffset;
            viewOffset = YcamTurnAngle * viewOffset;

        }

        if (currentView == views[1] || currentView == views[2])
        {
            currentAngle = new Vector3(
                    Mathf.LerpAngle(transform.rotation.eulerAngles.x, currentView.transform.eulerAngles.x, Time.deltaTime * transitionSpeedIsometric),
                    Mathf.LerpAngle(transform.rotation.eulerAngles.y, currentView.transform.eulerAngles.y, Time.deltaTime * transitionSpeedIsometric),
                    Mathf.LerpAngle(transform.rotation.eulerAngles.z, currentView.transform.eulerAngles.z, Time.deltaTime * transitionSpeedIsometric));
        }

        transform.eulerAngles = currentAngle;
        
        if (currentView == views[0])
        {
            transform.LookAt(currentView);
        }
    }
}
