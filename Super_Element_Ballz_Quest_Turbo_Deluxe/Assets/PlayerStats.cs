using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    [HideInInspector]
    public static int CollectiblesPickedUp;

    private void OnGUI()
    {
        GUI.Label(new Rect(20, 100, 100, 100), "Collectibles picked up " + CollectiblesPickedUp);
    }
}
