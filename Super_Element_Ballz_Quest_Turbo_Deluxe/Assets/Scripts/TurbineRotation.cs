using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurbineRotation : MonoBehaviour
{

    public Transform child;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, 150, 0) * Time.deltaTime);
        //child.transform.rotation = Quaternion.Euler(gameObject.transform.rotation.x , gameObject.transform.rotation.y , gameObject.transform.rotation.z);
    }
}
