using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallDash : MonoBehaviour
{
    [HideInInspector]
    public bool isDashing;

    [HideInInspector]
    public float dashTime = 8f;
    [HideInInspector]
    public float dashCooldown = 10f;

    public BallMovement ballMovement;

    private float baseForceFactor;
    private float dashForceFactor;
    [SerializeField]
    private float dashForceAddition;

    // Start is called before the first frame update
    private void Start()
    {
        baseForceFactor = ballMovement.groundForceFactor;
        dashForceFactor = baseForceFactor + dashForceAddition;
        ballMovement = gameObject.GetComponent<BallMovement>();
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            SetDashing(true);
        }

        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            SetDashing(false);
        }

        if(isDashing)
        {
            ballMovement.groundForceFactor = dashForceFactor;
        }
        else
        {
            ballMovement.groundForceFactor = baseForceFactor;
        }
    }

    public void SetDashing(bool state)
    {
        isDashing = state;
    }
}
