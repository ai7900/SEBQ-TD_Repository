using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiHandler : MonoBehaviour
{
    [SerializeField]
    public GameObject moveCollectibles;
    [SerializeField]
    private Transform showCollectiblePos;
    private Vector3 originalCollectionPos;
    private float collectibleTimer;
    private float collectibleStartTimer;
    private bool showCollectibles;
    [SerializeField]
    private Text deathCounterText;
    [SerializeField]
    private Text timerText;
    [SerializeField]
    private Text airChargeText;
    [SerializeField]
    private Text stoneChargeText;
    [SerializeField]
    private Text collectibleText;

    private static float timeSpent;

    private string minutes;
    private string seconds;
    void Start()
    {
        collectibleStartTimer = 4.0f;
        showCollectibles = false;
        originalCollectionPos = moveCollectibles.transform.position;
    }

    void Update()
    {
        collectibleText.text = "x" + PlayerStats.collectiblesPickedUp;
        deathCounterText.text = "x" + PlayerStats.deathCount;
        timerText.text = minutes + ":" + seconds;
        airChargeText.text = "x" + PlayerStats.lightFormCount;
        stoneChargeText.text = "x" + PlayerStats.heavyFormCount;
        timeSpent = Time.time;
        minutes = ((int)timeSpent / 60).ToString();
        seconds = (timeSpent % 60).ToString("f0");


        if (timeSpent < collectibleTimer)
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
}
