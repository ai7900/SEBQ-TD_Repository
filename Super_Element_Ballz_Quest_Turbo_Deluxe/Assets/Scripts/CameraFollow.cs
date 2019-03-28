using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public Transform target;
    public float smoothing = 5f;
    Vector3 offset;
    Vector3 targetCamPos;

    private void Start()
    {
        offset = transform.position - target.position;
    }

    private void Update()
    {

    }

    private void LateUpdate()
    {
        //if (target.transform.position.y < -30 || target.transform.position.y > 60)
        //{
        //    transform.position = target.transform.position + offset;
        //}

        AssignNewCameraTarget();

        targetCamPos = target.position + offset;
        transform.position = Vector3.Lerp(transform.position, targetCamPos, smoothing * Time.deltaTime);

    }

    private void AssignNewCameraTarget()
    {
        if (!target)
        {
            target = GameObject.FindWithTag("Player").transform;
        }
    }

}
