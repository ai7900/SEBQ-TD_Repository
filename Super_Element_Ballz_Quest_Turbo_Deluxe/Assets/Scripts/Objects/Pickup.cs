using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    private Vector3 posOffset = Vector3.zero;
    private Vector3 tempPos = Vector3.zero;

    [SerializeField]
    [Range(0.0f, 0.5f)]
    private float amplitude = 0.15f;
    [SerializeField]
    [Range(0.0f, 0.5f)]
    private float frequency = 0.4f;

    private void Start()
    {
        posOffset = transform.position;
    }

    private void Update()
    {
        tempPos = posOffset;
        tempPos.y += Mathf.Sin(Time.fixedTime * Mathf.PI * frequency) * amplitude;

        transform.position = tempPos;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (gameObject.CompareTag("LightPickup"))
        {
            PlayerStats.lightFormCount++;
            FindObjectOfType<AudioManager>().Play("AbilityPickup");
        }
        if (gameObject.CompareTag("HeavyPickup"))
        {
            PlayerStats.heavyFormCount++;
            FindObjectOfType<AudioManager>().Play("AbilityPickup");
        }
        
        Destroy(gameObject);
    }
}
