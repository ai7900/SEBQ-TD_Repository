using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
        ChildRotation();

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

    private void ChildRotation()
    {
        //child.transform.localRotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, transform.rotation.z);
        ////child.transform.rotation = Quaternion.Euler(0.0f, ground.transform.rotation.y, transform.rotation.z);
        //Vector3 targetPos = new Vector3(transform.position.x, child.transform.position.y, transform.position.z);
        //child.transform.LookAt(targetPos);
        ////child.transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, transform.rotation.z);
    }

    private void OnGUI()
    {
        GUI.Label(new Rect(20, 150, 300, 300), "Camera rotation " + child.transform.rotation);
    }




}
