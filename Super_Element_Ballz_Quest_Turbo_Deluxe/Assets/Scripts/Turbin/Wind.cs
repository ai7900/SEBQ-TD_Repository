using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wind : MonoBehaviour
{
    public float windForce;
    //public bool  isFacingLeft,isFacingRight,isFacingUp;
    private Vector3 windDirection;
    
    // Start is called before the first frame update
    void Start()
    {
        //Sets windarea position in front of turbine
        transform.localPosition = new Vector3(0, 6, 0);       
    }


    private void OnTriggerStay(Collider other)
    {
        //Debug.Log("Object is within trigger");
        windDirection = transform.up;

        //Debug.Log(windDirection);
        other.attachedRigidbody.AddForce(windDirection * windForce, ForceMode.Force);
        
    }
}
