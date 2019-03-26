using System.Collections;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    [SerializeField]
    public float moveSpeed;
    public float maxSpeed = 15f;

    //public static bool FireBall = false;

    private Rigidbody rb;

    public GameObject target; // target is the object you will take the rotations from

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {

        float xSpeed = Input.GetAxis("Horizontal");
        float ySpeed = Input.GetAxis("Vertical");

        rb.AddForce(xSpeed * target.transform.right * moveSpeed);
        rb.AddForce(ySpeed * target.transform.forward * moveSpeed);
        rb.velocity = Vector3.ClampMagnitude(rb.velocity, maxSpeed); // <-- Ska sätta en speedCap på bollen men funkar typ bara uppåt.
    }

    //private void FixedUpdate()
    //{

    //}

    private void OnGUI()
    {
        GUI.Label(new Rect(20, 20, 300, 300), "rigidbody velocity: " + rb.velocity);
    }



}
