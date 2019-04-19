using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorMovement : MonoBehaviour
{
    private Vector3 offset;
    private float lerpOffsetY = 2;  //To keep the speed

    [Header("Travel distance")]
    [SerializeField]
    [Range(1.0f, 100.0f)]
    private float topCheckpointY = 1f;
    private Vector3 bottomCheckpoint;

    [Header("The speed of the elevator")]
    [SerializeField]
    [Range(0.01f, 10f)]
    private float speed = 1f;

    private Vector3 tempPos = Vector3.zero;

    private int currentDirection;

    enum Direction
    {
        goingUp,
        goingDown,
    }


    private void Start()
    {
        bottomCheckpoint = transform.position;
        tempPos = transform.position;
        offset = transform.position;

        currentDirection = (int)Direction.goingUp;
        StartCoroutine(StartIdle());
    }
    
    private void Update()
    {
        StartCoroutine(Idle());
    }

    //Used in the start method inorder for the platform to stay idle when spawn.
    IEnumerator StartIdle()
    {
        yield return new WaitForSeconds(2);
    }

    //Function that makes the script wait seconds
    //Because it's in update it will run like update.
    IEnumerator Idle()
    {
        tempPos = transform.position;

        switch (currentDirection)
        {
            case (int)Direction.goingUp:

                tempPos.y = Mathf.Lerp(tempPos.y, topCheckpointY + offset.y + lerpOffsetY, speed * Time.deltaTime);

                if (tempPos.y > topCheckpointY + offset.y)
                {
                    yield return new WaitForSeconds(1);
                    currentDirection = (int)Direction.goingDown;
                }

                break;

            case (int)Direction.goingDown:

                tempPos.y = Mathf.Lerp(tempPos.y, bottomCheckpoint.y - lerpOffsetY, speed * Time.deltaTime);

                if (tempPos.y < bottomCheckpoint.y)
                {
                    yield return new WaitForSeconds(1);
                    currentDirection = (int)Direction.goingUp;
                }

                break;

            default:

                break;
        }

        transform.position = tempPos;

    }
}
