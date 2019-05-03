using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private GameObject spawnPoint;
    private Rigidbody rb;

    [SerializeField]
    private int abyssLevel = -30;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        spawnPoint = GameObject.FindWithTag("Spawn");
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < abyssLevel)
        {
            Die();
        }
    }

    public void Die()
    {
        transform.position = spawnPoint.transform.position;
        rb.velocity = new Vector3(0, -1, 0);
        PlayerStats.deathCount++;
    }
}
