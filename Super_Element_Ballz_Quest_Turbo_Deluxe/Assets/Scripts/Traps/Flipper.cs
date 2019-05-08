using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flipper : MonoBehaviour
{
    [SerializeField]
    private float restPosition = 0f;
    [SerializeField]
    private float activePosition = 90f;
    [SerializeField]
    private float hitStrength = 10000f;
    [SerializeField]
    private float flipperDamper = 150f;

    private Vector3 flipDirection;
    private float flipForce = 500;

    private JointSpring spring;
    private HingeJoint hinge;

    private Color color;
    private Color startColor = new Color(0,1,0,1);
    private float maxColorValue = 1.0f;
    private float flipInterval = 1.0f;
    
    private Renderer rend;
    private float onFlipperTimer = 0;

    void Start()
    {
        hinge = GetComponent<HingeJoint>();
        hinge.useSpring = true;       
        rend = GetComponent<Renderer>();
        color = startColor;
        rend.material.color=color;
    }

    private void OnTriggerStay(Collider other)
    {     
        
        onFlipperTimer += Time.deltaTime;
        //Red color increases with time
        color.r = maxColorValue * onFlipperTimer;
        //Green color decreases with time
        color.g = maxColorValue - (maxColorValue*onFlipperTimer);
        //When 1 second has passed the flipper will flip
        if (onFlipperTimer > flipInterval)
        {
            RunSpring();
            spring.targetPosition = activePosition;
            Hinge();
            flipDirection = transform.up;
            other.attachedRigidbody.AddForce(flipDirection * flipForce, ForceMode.Force);
        }
        rend.material.color = color;
    }

    private void OnTriggerExit(Collider other)
    {
        onFlipperTimer = 0;        
        RunSpring();
        spring.targetPosition = restPosition;
        Hinge();
        color = startColor;
        rend.material.color = color;
    }

    private void Hinge()
    {
        hinge.spring = spring;
        hinge.useLimits = true;
    }
    private void RunSpring()
    {
        spring = new JointSpring();
        spring.spring = hitStrength;
        spring.damper = flipperDamper;
    }
}
