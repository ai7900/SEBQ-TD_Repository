using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private Transform TargetObject;
    public float followDistance = 2f;
    public float followHeight = 2f;
    public bool smoothedFollow = false;         //toggle this for hard or smoothed follow
    public float smoothSpeed = 5f;
    public bool useFixedLookDirection = false;
    public Vector3 fixedLookDirection = Vector3.one;

    //public Transform target;
    //public float smoothing = 5f;
    //Vector3 offset;
    //Vector3 targetCamPos;


    private void Start()
    {
        //offset = transform.position - target.position;
    }

    private void Update()
    {
    }

    private void LateUpdate()
    {
        TargetObject = GameObject.FindGameObjectWithTag("Player").transform;
        Vector3 lookToward = TargetObject.position - transform.position;
        if (useFixedLookDirection)
        {
            lookToward = fixedLookDirection;
        }


        //make it stay a fixed distance behind ball
        Vector3 newPos;
        newPos = TargetObject.position - lookToward.normalized * followDistance;
        newPos.y = TargetObject.position.y + followHeight;

        if (!smoothedFollow)
        {
            transform.position = newPos;    //move exactly to follow target
        }
        else   //  smoothed / soft follow
        {
            transform.position += (newPos - transform.position) * Time.deltaTime * smoothSpeed;
        }
        lookToward = TargetObject.position - transform.position;

        //make this camera look at target
        transform.forward = lookToward.normalized;

        



        //if (target.transform.position.y < -30 || target.transform.position.y > 60)
        //{
        //    transform.position = target.transform.position + offset;
        //}

        //AssignNewCameraTarget();

        //targetCamPos = target.position + offset;
        //transform.position = Vector3.Lerp(transform.position, targetCamPos, smoothing * Time.deltaTime);

    }

    private void AssignNewCameraTarget()
    {
        //if (!target)
        //{
        //    target = GameObject.FindWithTag("Player").transform;
        //}
    }

}
