using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HalfRotatingPlatform : MonoBehaviour
{
    [SerializeField]
    private float rotationSpeed = 15.0f;

    // Start is called before the first frame update
    private void Start()
    {
        transform.eulerAngles = new Vector3(transform.eulerAngles.x, 0, 0);
    }

    private IEnumerator PlatformMovement()
    {

        transform.Rotate(0, rotationSpeed * Time.deltaTime, 0, Space.World);

        if (transform.rotation.eulerAngles.y > 180)
        {
            rotationSpeed *= -1;
            yield return new WaitForSeconds(2);
        }

        if (transform.rotation.eulerAngles.y < 0)
        {
            rotationSpeed *= -1;
            yield return new WaitForSeconds(2);
        }
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(PlatformMovement());
    }
}
