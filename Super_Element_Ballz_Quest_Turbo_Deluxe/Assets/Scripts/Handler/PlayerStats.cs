using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{
    [SerializeField]
    public static int lightFormCount;
    [SerializeField]
    public static int heavyFormCount;

    private static float timeSpent;

    private string minutes;
    private string seconds;

    public static int currentMode = (int)BallMode.Normal;

    public static int deathCount;

    [HideInInspector]
    public static int collectiblesPickedUp;

    [SerializeField]
    private Text deathCounterText;
    [SerializeField]
    private Text timerText;
    [SerializeField]
    private Text collectibleText;
    [SerializeField]
    private int startingLightCount;
    [SerializeField]
    private int startingHeavyCount;

    private void Start()
    {
        lightFormCount = startingLightCount;
        heavyFormCount = startingHeavyCount;
    }

    private void Update()
    {
        collectibleText.text = "x" + collectiblesPickedUp;
        deathCounterText.text = "x" + deathCount;
        timeSpent = Time.time;
        minutes = ((int)timeSpent / 60).ToString();
        seconds = (timeSpent % 60).ToString("f0");

        timerText.text = minutes+ ":" + seconds;
    }

    private void OnGUI()
    {
        GUI.Label(new Rect(20, 20, 400, 400), "Collectibles picked up " + collectiblesPickedUp);
        GUI.Label(new Rect(20, 40, 100, 100), "Death count: " + deathCount);
        GUI.Label(new Rect(20, 60, 500, 500), "Light: " + lightFormCount + " Heavy: " + heavyFormCount);
    }
}