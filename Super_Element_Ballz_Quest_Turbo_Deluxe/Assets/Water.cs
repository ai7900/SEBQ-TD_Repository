using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Water : MonoBehaviour
{
    [SerializeField]
    Rigidbody rb;
    [SerializeField]
    private float waterLevel;
    public float floatHeight = 2;
    public float bounceDamp = 0.05f;
    Vector3 bouyancyCenterOffset;

    private float forceFactor;
    private Vector3 actionPoint;
    private Vector3 upLift;

    RectTransform rt;

    void Start()
    {
        waterLevel = transform.position.y + rt.rect.height;
    }

    void OnCollisionStay(Collision collision)
    {
        actionPoint = transform.position + transform.TransformDirection(bouyancyCenterOffset);
        forceFactor = 1f - ((actionPoint.y - waterLevel) / floatHeight);
        if (forceFactor > 0f)
        {
            upLift = -Physics.gravity * (forceFactor - rb.velocity.y * bounceDamp);
            rb.AddForceAtPosition(upLift, actionPoint);
        }

    }


}
