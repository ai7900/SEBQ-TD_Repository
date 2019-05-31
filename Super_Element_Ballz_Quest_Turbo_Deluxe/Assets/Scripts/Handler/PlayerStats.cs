using System;
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

    public static int currentMode = (int)BallMode.Normal;

    public static int deathCount;

    [HideInInspector]
    public static int collectiblesPickedUp;

    [HideInInspector]
    public double LevelScore { get; private set; }

    [HideInInspector]
    public static double TotalScore { get; private set; }

    [HideInInspector]
    public float TimeBonus { get; set; }

    [SerializeField]
    private int startingLightCount;
    [SerializeField]
    private int startingHeavyCount;

    private void Start()
    {
        lightFormCount = startingLightCount;
        heavyFormCount = startingHeavyCount;
        collectiblesPickedUp = 0;
        deathCount = 0;
    }

    private void FixedUpdate()
    {
        LevelScore = 100 * collectiblesPickedUp * ((float)collectiblesPickedUp / 20) - 700 * deathCount * ((float)deathCount / 8) + TimeBonus;
    }
    
    public void CalculateTotalScore()
    {
        TotalScore += LevelScore;
    }
}