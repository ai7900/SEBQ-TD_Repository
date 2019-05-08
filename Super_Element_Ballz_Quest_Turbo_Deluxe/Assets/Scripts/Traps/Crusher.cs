using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crusher : MonoBehaviour
{
    [SerializeField]
    private GameObject playerSpawn;
    private Vector3 speed;
    private Vector3 speedDown;
    private Vector3 speedUp;
    [SerializeField]
    private float ySpeed;
    [SerializeField]
    private float maxHeight = 7.0f;
    [SerializeField]
    private float minHeight = 0.4f;
    private bool chargeUp;
    // Start is called before the first frame update
    void Start()
    {
        chargeUp = true;
        speed = new Vector3 (0, ySpeed, 0);
        speedDown = new Vector3(0, -ySpeed * 3, 0);
        speedUp = speed;
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position += speed * Time.deltaTime;
        if (gameObject.transform.position.y > maxHeight)
        {
            speed = speedDown;
        }
        else if (gameObject.transform.position.y < minHeight)
        {
            speed = speedUp;
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag ==("Player"))
        {
            collision.gameObject.transform.position = playerSpawn.transform.position;
        }
    }
}
