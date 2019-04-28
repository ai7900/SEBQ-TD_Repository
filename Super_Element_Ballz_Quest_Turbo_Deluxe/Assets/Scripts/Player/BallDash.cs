using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallDash : MonoBehaviour
{
    [HideInInspector]
    public bool isDashing;

    [HideInInspector]
    public float dashTime = 5f;
    [HideInInspector]
    public float dashCooldown = 30f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            SetDashing(true);
        }

        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            SetDashing(false);
        }

    }

    private void SetDashing(bool state)
    {
        isDashing = state;
    }

    //private void Dash()
    //{
    //    if (!isDashing && dashbar.fillAmount < 1.0f)
    //    {
    //        dashbar.fillAmount += 1.0f / dashCooldown * Time.deltaTime;
    //    }
    //    else if (isDashing)
    //    {
    //        dashbar.fillAmount -= 1.0f / dashTime * Time.deltaTime;

    //        if (dashbar.fillAmount <= 0)
    //        {
    //            isDashing = false;
    //            groundForceFactor -= dashForceFactor;
    //            forceFactor = groundForceFactor;
    //        }
    //    }
    //}
}
