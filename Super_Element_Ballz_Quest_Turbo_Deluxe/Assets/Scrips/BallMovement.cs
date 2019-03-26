using System.Collections;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    [SerializeField]
    public float moveSpeed = 5000f;

    Vector3 forward, right;

    private void Start()
    {
        forward = Camera.main.transform.forward;
        forward.y = 0;

        right = Quaternion.Euler(new Vector3(0,90, 0)) * forward;

        
    }

    private void Update()
    {

        //if (Input.anyKey)
        //    Move();

        Vector3 xSpeed = Input.GetAxis("Horizontal") * right * moveSpeed * Time.deltaTime;
        Vector3 ySpeed = Input.GetAxis("Vertical") * forward * moveSpeed * Time.deltaTime;

        transform.position += xSpeed;
        transform.position += ySpeed;

        //Rigidbody body = GetComponent<Rigidbody>();
        //body.AddTorque(new Vector3(xSpeed, 0, ySpeed) * moveSpeed * Time.deltaTime);
    }

    //void Move()
    //{
    //    Vector3 direction = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
    //    Vector3 upMovement = forward * moveSpeed * Time.deltaTime * Input.GetAxis("Horizontal");
    //    Vector3 rightMovement = right * moveSpeed * Time.deltaTime * Input.GetAxis("Vertical");

    //    //Vector3 heading = Vector3.Normalize(rightMovement + upMovement);

    //    //transform.forward = heading;    //rotation

    //    Rigidbody body = GetComponent<Rigidbody>();
    //    body.AddTorque(rightMovement + upMovement);

    //    //transform.position += rightMovement;
    //    //transform.position += upMovement;
    //}

}
