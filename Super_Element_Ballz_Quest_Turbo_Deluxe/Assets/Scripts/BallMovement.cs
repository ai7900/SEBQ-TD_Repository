using System.Collections;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    [SerializeField]
    public float moveSpeed;
    public float maxSpeed = 20f;

    float xSpeed;
    float ySpeed;
    
    //public static bool FireBall = false;

    private Rigidbody rb;

    public GameObject target; // target is the object you will take the rotations from
    public GameObject spawnPoint;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        target = GameObject.FindWithTag("Target Camera");
    }

    private void Update()
    {
        xSpeed = Input.GetAxis("Horizontal");
        ySpeed = Input.GetAxis("Vertical");

        rb.AddForce(xSpeed * target.transform.right * moveSpeed);
        rb.AddForce(ySpeed * target.transform.forward * moveSpeed);
        rb.AddForce(ySpeed * (target.transform.up * moveSpeed));

        rb.velocity = Vector3.ClampMagnitude(rb.velocity, maxSpeed);

        SpawnCheckpoint();
    }


    private void OnGUI()
    {
        GUI.Label(new Rect(20, 20, 300, 300), "rigidbody velocity: " + rb.velocity);
        GUI.Label(new Rect(20, 40, 300, 300), "xSpeed = " + xSpeed + "\nySpeed = " + ySpeed);
    }

    private void SpawnCheckpoint()
    {
        if(transform.position.y < -30)
        {
            transform.position = spawnPoint.transform.position;
            rb.velocity = new Vector3(0, 20, 0);
        }
    }



}
