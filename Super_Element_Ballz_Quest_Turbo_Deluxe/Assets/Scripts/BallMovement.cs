using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class BallMovement : MonoBehaviour
{
    [SerializeField]
    float groundForceFactor;

    [SerializeField]
    float maxSpeed = 20f;

    [SerializeField]
    float airborneForceFactor;

    private float forceFactor;
    private float xSpeed;
    private float ySpeed;
    private int abyssLevel = -30;
    private bool isAirborne;
    

    private Vector3 forward = Vector3.zero;
    private Vector3 movement = Vector3.zero;

    private Rigidbody rb;

    public GameObject target; // target is the object you will take the rotations from
    public GameObject spawnPoint;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        target = GameObject.FindWithTag("CameraTarget");
        spawnPoint = GameObject.FindWithTag("Spawnpoint");
        forceFactor = airborneForceFactor;
        isAirborne = true;
    }

    private void FixedUpdate()
    {
        xSpeed = Input.GetAxis("Horizontal");
        ySpeed = Input.GetAxis("Vertical");
        ApplyForce();

        if(!isAirborne)
        {
            if (rb.velocity.magnitude > maxSpeed)
            {
                rb.velocity = rb.velocity.normalized * maxSpeed;
            }
        }
        SpawnCheckpoint();
    }


    private void OnGUI()
    {
        GUI.Label(new Rect(20, 20, 300, 300), "rigidbody velocity: " + rb.velocity);
        GUI.Label(new Rect(20, 40, 300, 300), "xSpeed = " + xSpeed + "\nySpeed = " + ySpeed);
        GUI.Label(new Rect(20, 80, 300, 300), "It is " + isAirborne + " that the player is airborne");
    }

    //Denna metoden ska skicka tillbaka spelaren till startpunkten för nivån när denne faller av banan.
    private void SpawnCheckpoint()
    {
        if(transform.position.y < abyssLevel)
        {
            transform.position = spawnPoint.transform.position;
            rb.velocity = new Vector3(0, -1, 0);
        }
    }

    //Denna metod ska ta hand om krafterna som läggs på bollen när den spelaren använder perspektiv kamera och inte en isometrisk kamera
    private void ApplyForce()
    {
        rb.AddForce(xSpeed * target.transform.right * forceFactor);
        rb.AddForce(ySpeed * target.transform.forward * forceFactor);
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag != "Trap")
        {
            isAirborne = false;
            forceFactor = groundForceFactor;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag != "Trap")
        {
            isAirborne = true;
            forceFactor = airborneForceFactor;
        }
    }
}
