using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spike : MonoBehaviour
{
    private void OnTriggerEnter(Collider player)
    {
        if (player.CompareTag("Player") && PlayerStats.currentMode == (int)BallMode.Light)
        {
            player.gameObject.GetComponent<Player>().Die();
        }
    }
}
