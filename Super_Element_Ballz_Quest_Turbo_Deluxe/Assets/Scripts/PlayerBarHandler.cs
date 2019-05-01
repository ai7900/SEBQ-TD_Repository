using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerBarHandler : MonoBehaviour
{
    [SerializeField]
    private Image dashbar;

    [SerializeField]
    private GameObject player;
    [SerializeField]
    private BallDash playerDash;

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
            playerDash = player.GetComponent<BallDash>();
        }

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

    private void OnGUI()
    {
        GUI.Label(new Rect(20, 60, 300, 300), "Fill amount = " + dashbar.fillAmount);
    }
}
