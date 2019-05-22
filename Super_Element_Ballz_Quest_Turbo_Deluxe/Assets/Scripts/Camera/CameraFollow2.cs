using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow2 : MonoBehaviour
{

    public float cameraMoveSpeed = 120.0f;
    public GameObject cameraFollowObject;
    Vector3 followPos;
    public float clampAngle = 80.0f;
    public float inputSensitivity = 150.0f;
    public GameObject cameraObj;
    public GameObject playerObj;
    public float camDistanceXToPlayer;
    public float camDistanceYToPlayer;
    public float camDistanceZToPlayer;
    public float mouseX;
    public float mouseY;
    public float finalInputX;
    public float finalInputZ;
    public float smoothX;
    public float smoothY;
    private float rotY = 0.0f;
    private float rotX = 0.0f;

    void Start()
    {
        Vector3 rot = transform.localRotation.eulerAngles;
        rotY = rot.y;
        rotX = rot.x;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        //Added a try and catch
        try
        {
            cameraFollowObject = GameObject.FindGameObjectWithTag("Player");
        }
        catch (MissingReferenceException e)
        {

        }

        float inputX = Input.GetAxis("RightStickHorizontal");
        float inputZ = Input.GetAxis("RightStickVertical");
        mouseX = Input.GetAxis("Mouse X");
        mouseY = Input.GetAxis("Mouse Y");
        finalInputX = (inputX + mouseX) * inputSensitivity;
        finalInputZ = -(inputZ + mouseY) * inputSensitivity;
        rotY += finalInputX * Time.deltaTime;
        rotX += finalInputZ * Time.deltaTime;
        rotX = Mathf.Clamp(rotX, -clampAngle, clampAngle);
        Quaternion localRotation = Quaternion.Euler(rotX, rotY, 0.0f);
        transform.rotation = localRotation;
    }

    void LateUpdate()
    {
        CameraUpdater();
    }
    void CameraUpdater()
    {
        //Added try catch
        try
        {
            Transform target = cameraFollowObject.transform;
            float step = cameraMoveSpeed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, target.position, step);
        }
        catch (MissingReferenceException e)
        {

        }

    }
}
