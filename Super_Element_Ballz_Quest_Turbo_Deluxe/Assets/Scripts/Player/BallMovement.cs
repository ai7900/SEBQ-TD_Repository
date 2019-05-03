using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class BallMovement : MonoBehaviour
{
    [SerializeField]
    public float groundForceFactor = 0;

    [SerializeField]
    private float maxSpeed = 20f;

    [SerializeField]
    private float airborneForceFactor = 0;

    private float forceFactor = 0;
    private float xSpeed = 0;
    private float zSpeed = 0;

    private bool isAirborne = true;

    //Borde vara ett värde mellan 1.5 och 1.9, högre värde gör det lättare för spelaren att accelerera ytterligare när denne redan är i toppfart.
    private double accelerationTolerance = 1.8; 
    
    private Vector3 xMovement = Vector3.zero;
    private Vector3 zMovement = Vector3.zero;

    private Rigidbody rb;
    public GameObject target; // target is the object you will take the rotations from

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        target = GameObject.FindWithTag("PlayerDirection");
        forceFactor = airborneForceFactor;
    }

    private void FixedUpdate()
    {
        FindDirectionHelper();

        xSpeed = Input.GetAxis("Horizontal");
        zSpeed = Input.GetAxis("Vertical");
        xMovement = target.transform.right * xSpeed;
        zMovement = target.transform.forward * zSpeed;

        if(CanAccelerate())
        {
            ApplyForce();
        }

    }

    private void OnGUI()
    {
        GUI.Label(new Rect(20, 20, 300, 300), "rigidbody velocity: " + rb.velocity);
        GUI.Label(new Rect(20, 40, 300, 300), "ground force factor = " + groundForceFactor);
    }
    
    //Denna metoden ska skicka tillbaka spelaren till startpunkten för nivån när denne faller av banan.
    private void RespawnPlayer()
    {

    }

    //Tar hand om krafterna som läggs till på bollen
    private void ApplyForce()
    {
        rb.AddForce(xMovement * forceFactor);
        rb.AddForce(zMovement * forceFactor);
    }

    private void FindDirectionHelper()
    {
        if (!target)
        {
            target = GameObject.FindWithTag("PlayerDirection");
        }
    }

    //Metoden kontrollerar om spelaren har nått toppfarten och försöker accelerera ytterligare i riktningen som denne är påväg i redan.
    private bool CanAccelerate()
    {
        if (rb.velocity.magnitude > maxSpeed)
        {
            if ((rb.velocity.normalized + zMovement + xMovement).magnitude > accelerationTolerance)
            {
                return false;
            }
            else return true;
        }
        else return true;
    }

    private void OnTriggerStay(Collider other)
    {
        if (!other.CompareTag("Trap"))
        {
            isAirborne = false;
            forceFactor = groundForceFactor;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Trap"))
        {
            isAirborne = true;
            forceFactor = airborneForceFactor;
        }
    }
}
