using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pendel : MonoBehaviour
{
    private Quaternion start, end;
    [SerializeField]
    private float angle = 90.0f;
    [SerializeField]
    private float speed = 2.0f;
    [SerializeField]
    private float startTime = 0.0f;

    void Start()
    {
        start = PendulumRotation(angle);
        end = PendulumRotation(-angle);
    }
    void ResetTimer()
    {
        startTime = 0.0f;
        
    }

    Quaternion PendulumRotation(float angle)
    {
        var pendulumRotation = transform.rotation;
        var angleZ = pendulumRotation.eulerAngles.z + angle;

        if (angleZ > 180)
            angleZ -= 360;
        else if (angleZ < -180)
            angleZ += 360;
        pendulumRotation.eulerAngles = new Vector3(pendulumRotation.eulerAngles.x, pendulumRotation.eulerAngles.y, angleZ);
        return pendulumRotation;
    }

    void FixedUpdate()
    {
        startTime += Time.deltaTime;
        transform.rotation = Quaternion.Lerp(start, end, (Mathf.Sin(startTime * speed * Mathf.PI / 2) + 1.0f)/2.0f);
    }
}
