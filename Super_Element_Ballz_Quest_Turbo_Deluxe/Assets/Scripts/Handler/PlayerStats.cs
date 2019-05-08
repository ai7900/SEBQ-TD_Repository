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
        GUI.Label(new Rect(20, 20, 400, 400), "Collectibles picked up " + collectiblesPickedUp);
        GUI.Label(new Rect(20, 40, 100, 100), "Death count: " + deathCount);
        GUI.Label(new Rect(20, 60, 500, 500), "Light: " + lightFormCount + " Heavy: " + heavyFormCount);
    }
}