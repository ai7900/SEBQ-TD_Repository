using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreezeWater : MonoBehaviour
{
    private bool willSpawnIce = true;
    [SerializeField]
    private GameObject icePrefab;
    [SerializeField]
    private Transform iceTarget;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Water"))
        {
            if (willSpawnIce)
            {
                GameObject plateIce = Instantiate(icePrefab,
                    new Vector3(iceTarget.position.x, iceTarget.position.y, iceTarget.position.z), new Quaternion(0, 0, 0, 0));
                willSpawnIce = false;
                Destroy(plateIce, 15);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Ice"))
        {
            willSpawnIce = true;
        }
    }
}
