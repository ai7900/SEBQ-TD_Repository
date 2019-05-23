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
    [SerializeField]
    public GameObject moveCollectibles;
    [SerializeField]
    private Transform showCollectiblePos;
    private Vector3 originalCollectionPos;
    private float collectibleTimer;
    private float collectibleStartTimer;
    private bool showCollectibles;

    private void Start()
    {
        lightFormCount = startingLightCount;
        heavyFormCount = startingHeavyCount;
        collectibleStartTimer = 4.0f;
        showCollectibles = false;
        originalCollectionPos = moveCollectibles.transform.position;
    }

    private void Update()
    {
        collectibleText.text = "x" + collectiblesPickedUp;
        deathCounterText.text = "x" + deathCount;
        timeSpent = Time.time;
        minutes = ((int)timeSpent / 60).ToString();
        seconds = (timeSpent % 60).ToString("f0");
        timerText.text = minutes+ ":" + seconds;

        if(timeSpent < collectibleTimer)
        {
            showCollectibles = true;
        }
        else
        {
            showCollectibles = false;
        }

        try
        {
            if (showCollectibles)
            {
                moveCollectibles.transform.position = Vector3.MoveTowards(showCollectiblePos.position, originalCollectionPos, 0.1f * Time.deltaTime);
            }
            else if (!showCollectibles)
            {
                moveCollectibles.transform.position = Vector3.MoveTowards(originalCollectionPos, showCollectiblePos.position, 0.1f * Time.deltaTime);
            }
        }
        catch (Exception e)
        {
            Debug.Log(e.Message);
        }
        
        
    }
    public void ShowCollectibles()
    {
        collectibleTimer = Time.time + collectibleStartTimer;
    }
    private void OnGUI()
    {
        GUI.Label(new Rect(20, 60, 500, 500), "Light: " + lightFormCount + " Heavy: " + heavyFormCount);
    }
}