using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    [SerializeField]
    public static int lightFormCount;
    [SerializeField]
    public static int heavyFormCount;

    public static int currentMode = (int)BallMode.Normal;

    public static int deathCount;

    [HideInInspector]
    public static int collectiblesPickedUp;

    [SerializeField]
    private int startingLightCount;
    [SerializeField]
    private int startingHeavyCount;

    private void Start()
    {
        lightFormCount = startingLightCount;
        heavyFormCount = startingHeavyCount;
    }

    private void OnGUI()
    {
        GUI.Label(new Rect(20, 100, 400, 400), "Collectibles picked up " + collectiblesPickedUp);
        GUI.Label(new Rect(20, 120, 100, 100), "Death count: " + deathCount);
        GUI.Label(new Rect(20, 140, 500, 500), "Light: " + lightFormCount + " Heavy: " + heavyFormCount);
    }
}