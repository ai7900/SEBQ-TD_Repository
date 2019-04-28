using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerBarHandler : MonoBehaviour
{
    private Image dashbar;
    private GameObject player;
    private BallDash playerDash;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!player)
        {
            player = GameObject.FindWithTag("Player");
            playerDash = player.GetComponent<BallDash>();
        }

        if(playerDash.isDashing)
        {
            dashbar.fillAmount -= 1.0f / playerDash.dashTime * Time.deltaTime;
        }
        else if(playerDash.isDashing == false)
        {
            dashbar.fillAmount += 1.0f / playerDash.dashCooldown * Time.deltaTime;
        }
    }
}
