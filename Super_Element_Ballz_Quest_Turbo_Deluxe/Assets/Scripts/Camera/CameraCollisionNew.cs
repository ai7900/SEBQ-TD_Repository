using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCollisionNew : MonoBehaviour
{
    [SerializeField]
    private float minDistance = 1.0f;
    [SerializeField]
    private float maxDistance = 4.0f;
    [SerializeField]
    private float smooth = 10.0f;
    private Vector3 dollyDir;
    private Vector3 dollyDirAdjusted;
    [SerializeField]
    private float distance;

    // Start is called before the first frame update
    private void Awake()
    {
        dollyDir = transform.localPosition.normalized;
        distance = transform.localPosition.magnitude;
    }

    // Update is called once per frame
    private void Update()
    {
        Vector3 desiredCameraPos = transform.parent.TransformPoint(dollyDir * maxDistance);
        RaycastHit hit;

        if (Physics.Linecast(transform.parent.position, desiredCameraPos, out hit))
        {
            if (hit.collider.CompareTag("Environment"))
            {
                distance = Mathf.Clamp(hit.distance * 0.9f, minDistance, maxDistance);
            }
            else return;

        }
        else
        {
            distance = maxDistance;
        }
        transform.localPosition = Vector3.Lerp(transform.localPosition, dollyDir * distance, Time.deltaTime * smooth);
        
    }
}
