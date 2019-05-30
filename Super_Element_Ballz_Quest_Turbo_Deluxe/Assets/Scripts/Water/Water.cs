using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Water : MonoBehaviour
{
    [SerializeField]
    private Rigidbody rb;
    [SerializeField]
    private float waterLevel;
    public float floatHeight = 1.5f;
    private float dampFactor = 0.05f;
    private float impactDamp = 0.8f;
    private Vector3 bouyancyCenterOffset = Vector3.zero;

    private float forceFactor;
    private Vector3 actionPoint;
    private Vector3 upLift;

    private float weakForceFactor;

    private float magicNumber = .5f;
    private float magicDivisor = 4;

    private RectTransform rt;
    //private BallModeController ballModeController;
    private Transform waterHeight;


    private void Start()
    {
        waterLevel = transform.position.y * 2;
        floatHeight = -.5f;
        forceFactor = 5f;
        weakForceFactor = 3f;
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if(PlayerStats.currentMode == (int)BallMode.Light || PlayerStats.currentMode == (int)BallMode.Ice)
            {
                rb = other.gameObject.GetComponent<Rigidbody>();
                actionPoint = other.transform.position + other.transform.TransformDirection(bouyancyCenterOffset);
                if (forceFactor > 0f)
                {
                    if (rb.velocity.y >= 0)
                    {
                        upLift = -Physics.gravity * (forceFactor + rb.velocity.y * dampFactor);
                    }
                    if (rb.velocity.y < 0)
                    {
                        upLift = -Physics.gravity * (forceFactor - rb.velocity.y * impactDamp);
                    }
                    rb.AddForceAtPosition(upLift, actionPoint);
                }
            }

            else if(PlayerStats.currentMode == (int)BallMode.Heavy || PlayerStats.currentMode == (int)BallMode.Normal)
            {
                rb = other.gameObject.GetComponent<Rigidbody>();
                BallMovement ballMove = other.gameObject.GetComponent<BallMovement>();
                
                actionPoint = other.transform.position + other.transform.TransformDirection(bouyancyCenterOffset);
                if (weakForceFactor > 0f)
                {
                    if(rb.velocity.y >= 0)
                    {
                        upLift = -Physics.gravity * (weakForceFactor + rb.velocity.y * dampFactor);
                    }
                    if(rb.velocity.y < 0)
                    {
                        upLift = -Physics.gravity * (weakForceFactor - rb.velocity.y * impactDamp);
                    }

                    rb.AddForceAtPosition(upLift, actionPoint);
                }
            }
            else if (PlayerStats.currentMode == (int)BallMode.Fire)
            {
                Player playerScript = other.gameObject.GetComponent<Player>();
                playerScript.Die();
            }

        }

    }

}
