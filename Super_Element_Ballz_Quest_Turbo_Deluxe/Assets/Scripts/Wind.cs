using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wind : MonoBehaviour
{
    public float windForce;
    public bool  isFacingLeft;
    private Vector3 pushback;
    float distance;
    

    // Start is called before the first frame update
    void Start()
    {
        transform.localPosition = new Vector3(0, 6, 0);
        
        
        
    }

    

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
       
        Debug.Log("Object is within trigger");
        distance = Vector3.Distance(transform.position, other.transform.position);
        pushback = transform.eulerAngles;
      
        pushback.Normalize();

        if(isFacingLeft)
        {
            pushback = new Vector3(-1, 0, 0);
        }
       
        Debug.Log(pushback);
        
        other.attachedRigidbody.AddForce(pushback * windForce, ForceMode.Acceleration);
        //
    }
}
