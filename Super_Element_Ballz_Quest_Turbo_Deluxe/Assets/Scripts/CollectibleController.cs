﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleController : MonoBehaviour
{
    private float rotationX = 5;
    private float rotationY = 50;
    private float rotationZ = 2.5f;

    private Vector3 posOffset = Vector3.zero;
    private Vector3 tempPos = Vector3.zero;

    private float frequency = 0.25f;

    [SerializeField]
    [Range(0.0f, 0.5f)]
    private float amplitude = 0.1f;

    private void Start()
    {
        posOffset = transform.position;
        transform.eulerAngles = new Vector3(transform.eulerAngles.x, Random.value * 360, transform.eulerAngles.z);
    }

    private void Update()
    {
        transform.Rotate(new Vector3(0, rotationY, 0) * Time.deltaTime, Space.World);
        transform.Rotate(new Vector3(rotationX, 0, rotationZ) * Time.deltaTime, Space.Self);

        tempPos = posOffset;
        tempPos.y += Mathf.Sin(Time.fixedTime * Mathf.PI * frequency) * amplitude;

        transform.position = tempPos;

        if (transform.rotation.eulerAngles.z > 15 || transform.rotation.eulerAngles.z < -15)
        {
            rotationZ *= -1;
        }


        if (transform.rotation.eulerAngles.x > 15 || transform.rotation.eulerAngles.x < -15)
        {
            rotationX *= -1;
        }

        
    }
}