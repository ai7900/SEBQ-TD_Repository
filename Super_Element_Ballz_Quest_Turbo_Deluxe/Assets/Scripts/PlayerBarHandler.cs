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
    }

    private void HandleDashbar()
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

    private void HandleFirebar()
    {
        if (ballMode.ChargingFire)
        {
            firebar.fillAmount += 1.0f / ballMode.fireChargeTime * Time.deltaTime;   
        }
        else if (ballMode.ChargingFire == false)
        {
            firebar.fillAmount -= 1.0f / ballMode.fireDuration * Time.deltaTime;
            if (firebar.fillAmount <= 0 && PlayerStats.currentMode == (int)BallMode.Fire)
            {
                ballMode.TurnIntoNormalBall();
            }
        }
    }

    private void HandleIcebar()
    {

    }

    private void OnGUI()
    {
        GUI.Label(new Rect(20, 60, 300, 300), "Fill amount = " + firebar.fillAmount);
    }
}
