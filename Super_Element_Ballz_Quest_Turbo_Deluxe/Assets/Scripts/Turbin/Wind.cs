using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wind : MonoBehaviour
{
    [SerializeField]
    private float windForce;

    private Vector3 windDirection;
    private Vector3 windPosition = new Vector3(0, 6, 0);
    
    // Start is called before the first frame update
    void Start()
    {
        //Sets windarea position in front of turbine
        transform.localPosition = windPosition;       
    }


    private void OnTriggerStay(Collider other)
    {
        windDirection = transform.up;
        other.attachedRigidbody.AddForce(windDirection * windForce, ForceMode.Force);       
    }
}
