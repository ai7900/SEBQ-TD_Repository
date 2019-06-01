using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow2 : MonoBehaviour
{
    [SerializeField]
    private float cameraMoveSpeed = 120.0f;
    [SerializeField]
    private GameObject cameraFollowObject;
    private Vector3 followPos;
    [SerializeField]
    private float clampAngle = 80.0f;
    [SerializeField]
    private float inputSensitivity = 150.0f;
    [SerializeField]
    private GameObject cameraObj;
    [SerializeField]
    private GameObject playerObj;
    private float camDistanceXToPlayer;
    private float camDistanceYToPlayer;
    private float camDistanceZToPlayer;
    private float mouseX;
    private float mouseY;
    private float finalInputX;
    private float finalInputZ;
    private float smoothX;
    private float smoothY;
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
        try
        {
            Transform target = cameraFollowObject.transform;
            float step = cameraMoveSpeed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, target.position, step);
        }
        catch(Exception e)
        {

        }
    }
}
