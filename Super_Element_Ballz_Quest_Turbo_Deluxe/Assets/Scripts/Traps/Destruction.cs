using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruction : MonoBehaviour
{
    public GameObject destroyedVersion;
    [SerializeField]
    private float objectStrength;
    private Rigidbody playerRb;

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            playerRb = collider.gameObject.GetComponent<Rigidbody>();
            if (playerRb.mass * playerRb.velocity.magnitude > objectStrength)
            {
                Instantiate(destroyedVersion, transform.position, transform.rotation);
                Destroy(gameObject);
            }
        }
        
    }
}
