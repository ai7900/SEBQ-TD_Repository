using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Water : MonoBehaviour
{
    [SerializeField]
    Rigidbody rb;
    [SerializeField]
    private float waterLevel;
    public float floatHeight = 1.5f;
    public float bounceDamp = 0.05f;
    Vector3 bouyancyCenterOffset;

    private float forceFactor;
    private Vector3 actionPoint;
    private Vector3 upLift;

    RectTransform rt;

    void Start()
    {
        waterLevel =  transform.localScale.y;
    }

    void OnTriggerStay(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            rb = collision.gameObject.GetComponent<Rigidbody>();
            actionPoint = collision.transform.position + collision.transform.TransformDirection(bouyancyCenterOffset);
            forceFactor = 1f - ((actionPoint.y - waterLevel) / (floatHeight*transform.position.y));
            if (forceFactor > 0f)
            {
                upLift = -Physics.gravity * (forceFactor - rb.velocity.y * bounceDamp)*5;
                rb.AddForceAtPosition(upLift, actionPoint);
            }
        }

    }


}
