using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class BallMovement : MonoBehaviour
{
    [SerializeField]
    public float forceFactor;
    public float maxSpeed = 20f;

    private float xSpeed;
    private float ySpeed;
    private int abyssLevel = -30;

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
    }

    private void FixedUpdate()
    {
        xSpeed = Input.GetAxis("Horizontal");
        ySpeed = Input.GetAxis("Vertical");
        PerspectiveCameraMovement();
        SpawnCheckpoint();
    }


    private void OnGUI()
    {
        GUI.Label(new Rect(20, 20, 300, 300), "rigidbody velocity: " + rb.velocity);
        GUI.Label(new Rect(20, 40, 300, 300), "xSpeed = " + xSpeed + "\nySpeed = " + ySpeed);
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
    private void PerspectiveCameraMovement()
    {
        rb.AddForce(xSpeed* target.transform.right* forceFactor);
        rb.AddForce(ySpeed* target.transform.forward* forceFactor);
        rb.velocity = Vector3.ClampMagnitude(rb.velocity, maxSpeed);
    }



}
