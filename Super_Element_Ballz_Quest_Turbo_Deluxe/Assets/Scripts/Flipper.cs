using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flipper : MonoBehaviour
{
    public float restPosition = 0f;
    public float activePosition = 90f;
    public float hitStrength = 10000f;
    public float flipperDamper = 150f;
    private Vector3 flipDirection;
    private float flipForce = 500;

    JointSpring spring;

    HingeJoint hinge;
    Color color;
    Color startColor = new Color(0,1,0,1);
    float colorChange = 0.01f;
    
    private Renderer rend;
    private int onFlipperTimer = 0;

    // Start is called before the first frame update
    void Start()
    {
        hinge = GetComponent<HingeJoint>();
        hinge.useSpring = true;       
        rend = GetComponent<Renderer>();
        color = startColor;
        rend.material.color=color;
    }

    // Update is called once per frame
    void Update()
    {  
    }

    private void OnTriggerStay(Collider other)
    {
        
        onFlipperTimer++;
        color.r += colorChange;
        color.g -= colorChange;      
        Debug.Log("Flipper collide");

        if (onFlipperTimer > 100)
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
