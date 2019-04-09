using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Mattias Skrev koden 2019-04-03 I guess?
public class CameraFollow : MonoBehaviour
{
    [HideInInspector]
    public Transform targetTransform;

    [Header("Target")]
    public string targetTag;

    [Range(0.01f, 1.0f)]
    public float smoothFactor = 0.5f;

    [Header("Camera view")]
    public bool lookAtTarget;

    private Vector3 cameraOffset;

    private void Start()
    {
        targetTransform = GameObject.FindGameObjectWithTag(targetTag).transform;
    }

    private void FixedUpdate()
    {
            
    }

    // LateUpdate is called after Update methods
    private void LateUpdate()
    {
        AssignNewCameraTarget();
        Vector3 newPos = targetTransform.position;

        transform.position = Vector3.Slerp(transform.position, newPos, smoothFactor * Time.deltaTime);

        if (lookAtTarget)
        {
            transform.LookAt(targetTransform);
        }

    }

    private void AssignNewCameraTarget()
    {
        if (!targetTransform)
        {
            targetTransform = GameObject.FindWithTag(targetTag).transform;
        }

    }

    //private void OnGUI()
    //{
    //    GUI.Label(new Rect(20, 120, 300, 300), "PlayerPos = " + targetTransform.position);
    //}

}
