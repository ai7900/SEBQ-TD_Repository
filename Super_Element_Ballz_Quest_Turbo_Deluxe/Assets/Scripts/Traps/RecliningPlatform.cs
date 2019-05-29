using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecliningPlatform : MonoBehaviour
{
    private float speed;
    private float posX;
    private float startPosX;

    [SerializeField]
    private float secondsToWait = 1;

    // Start is called before the first frame update
    private void Start()
    {
        speed = 1f;
        posX = transform.position.x;
        startPosX = transform.position.x;

        StartCoroutine(StartWait());
    }

    private IEnumerator StartWait()
    {
        yield return new WaitForSecondsRealtime(secondsToWait);
    }

    private IEnumerator PlatformMovement()
    {
        transform.position = new Vector3(posX, transform.position.y, transform.position.z);

        posX += speed * Time.deltaTime;

        if(posX < 0)
        {
            speed *= -1;
            yield return new WaitForSeconds(0.2f);
        }
        
        if(posX > startPosX)
        {
            speed *= -1;
            yield return new WaitForSeconds(0.2f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(PlatformMovement());
    }
}
