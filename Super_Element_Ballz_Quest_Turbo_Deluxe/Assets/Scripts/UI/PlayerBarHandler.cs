using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerBarHandler : MonoBehaviour
{
    [SerializeField]
    private Image dashbar;
    [SerializeField]
    private Image firebar;
    [SerializeField]
    private Image icebar;

    [SerializeField]
    private GameObject player;
    private BallDash playerDash;
    private BallModeController ballMode;

    private int depletionRate = 3;

    // Start is called before the first frame update
    private void Start()
    {
        player = GameObject.FindWithTag("Player");
        playerDash = player.GetComponent<BallDash>();
    }

    // Update is called once per frame
    private void Update()
    {
        if (!player)
        {
            player = GameObject.FindWithTag("Player");
        }

        playerDash = player.GetComponent<BallDash>();
        ballMode = player.GetComponent<BallModeController>();

        HandleDashbar();
        HandleFirebar();
        HandleIcebar();
    }

    private void HandleDashbar()
    {
        if(PlayerStats.currentMode != (int)BallMode.Ice)
        {
            if (playerDash.isDashing)
            {
                dashbar.fillAmount -= 1.0f / playerDash.dashTime * Time.deltaTime;
                if (dashbar.fillAmount <= 0)
                {
                    playerDash.SetDashing(false);
                }
            }
            else if (playerDash.isDashing == false)
            {
                dashbar.fillAmount += 1.0f / playerDash.dashCooldown * Time.deltaTime;
            }
        }

    }

    private void HandleFirebar()
    {
        if (ballMode.ChargingFire)
        {
            firebar.fillAmount += 1.0f / ballMode.fireChargeTime * Time.deltaTime;
            icebar.fillAmount -= 1.0f / depletionRate * Time.deltaTime;
        }
        else
        {
            firebar.fillAmount -= 1.0f / ballMode.fireDuration * Time.deltaTime;
            if (firebar.fillAmount <= 0)
            {
                if(PlayerStats.currentMode == (int)BallMode.Fire && ballMode.ChargingFire == false)
                {
                    FindObjectOfType<AudioManager>().Stop("FireBall");
                    FindObjectOfType<AudioManager>().Play("FireExtinguish");
                    ballMode.TurnIntoNormalBall();
                }

            }
        }
    }

    private void HandleIcebar()
    {
        if (ballMode.ChargingIce)
        {
            icebar.fillAmount += 1.0f / ballMode.iceChargeTime * Time.deltaTime;
            firebar.fillAmount -= 1.0f / depletionRate * Time.deltaTime;
            if (icebar.fillAmount > 0)
            {
                ballMode.IceReady = true;
            }
        }
        else
        {
            icebar.fillAmount -= 1.0f / ballMode.iceDuration * Time.deltaTime;
            if (icebar.fillAmount <= 0)
            {
                ballMode.IceReady = false;
                if (PlayerStats.currentMode == (int)BallMode.Ice && ballMode.ChargingIce == false)
                {
                    ballMode.TurnIntoNormalBall();
                }

            }
        }
    }
}
