using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraAngleFollow : MonoBehaviour
{
    [SerializeField]
    private Transform target;

    // Update is called once per frame
    private void Update()
    {
        //Quaternion newRotation = new Quaternion();
        //newRotation.Set(0, Mathf.Abs(target.rotation.y), 0, 1);
        ////transform.SetPositionAndRotation(transform.position, Quaternion.Euler(transform.rotation.x, target.transform.rotation.y, transform.rotation.z));
        ////transform.Rotate(new Vector3(transform.rotation.x, target.transform.rotation.y, transform.rotation.z), Space.Self);
        ////transform.rotation = Quaternion.Euler(transform.rotation.x, target.rotation.y, transform.rotation.z);
        //transform.rotation = newRotation;

        //transform.rotation = Quaternion.Euler()

    }
}
