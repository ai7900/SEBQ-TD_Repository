using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    [HideInInspector]
    public static int collectiblesPickedUp;

    public static int deathCount;

    private void OnGUI()
    {
        GUI.Label(new Rect(20, 100, 100, 100), "Collectibles picked up " + collectiblesPickedUp);
        GUI.Label(new Rect(20, 120, 100, 100), "Death count: " + deathCount);
    }
}
