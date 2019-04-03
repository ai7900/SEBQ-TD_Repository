using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Kan användas till main menu också
public class CameraController : MonoBehaviour
{

    public Transform[] views;
    public float transitionSpeed;
    private Transform currentView;
    private Vector3 currentAngle;

    private Vector3 viewOffset = new Vector3(10f, 10f, 3f);

    public float rotationSpeed = 1f;

    private Vector2 input;

    private void Start()
    {
        currentView = views[1];
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            currentView = views[0]; //thirdperson
            
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            currentView = views[1]; //isometric
        }


    }

    private void LateUpdate()
    {
        //Lerp position
        if(currentView == views[0])
        {
            transform.position = Vector3.Lerp(transform.position, currentView.position + viewOffset, transitionSpeed * Time.deltaTime);
        }
        else
        {
            transform.position = Vector3.Lerp(transform.position, currentView.position, transitionSpeed * Time.deltaTime);
        }

        CameraRotation();

        
    }

    private void CameraRotation()
    {
        if (currentView == views[0])
        {
            //input += new Vector2(Input.GetAxis("Mouse X") * rotationSpeed, Input.GetAxis("Mouse Y") * rotationSpeed);

            //transform.localRotation = Quaternion.Euler(input.y, input.x, 0);
            //transform.localPosition = currentView.position - (transform.localRotation * Vector3.forward * 3f);

            Quaternion XcamTurnAngle = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * rotationSpeed, Vector3.up);
            //Quaternion YcamTurnAngle = Quaternion.AngleAxis(Input.GetAxis("Keyboard_Vertical") * rotationSpeed, Vector3.left);

            viewOffset = XcamTurnAngle * viewOffset;
            //viewOffset = YcamTurnAngle * viewOffset;

        }

        if (currentView == views[1])
        {
            currentAngle = new Vector3(
                    Mathf.LerpAngle(transform.rotation.eulerAngles.x, currentView.transform.eulerAngles.x, Time.deltaTime * transitionSpeed),
                    Mathf.LerpAngle(transform.rotation.eulerAngles.y, currentView.transform.eulerAngles.y, Time.deltaTime * transitionSpeed),
                    Mathf.LerpAngle(transform.rotation.eulerAngles.z, currentView.transform.eulerAngles.z, Time.deltaTime * transitionSpeed));
        }

        transform.eulerAngles = currentAngle;

        if (currentView == views[0])
        {
            transform.LookAt(currentView);
        }
    }


}
