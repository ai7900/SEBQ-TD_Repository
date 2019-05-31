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
    [SerializeField]
    private Text scoreText;

    private PlayerStats playerStats;
    Animator animator;

    [HideInInspector]
    public static float timeSpent;

    private string minutes;
    private string seconds;
    void Start()
    {
        timeSpent = 0;
        collectibleStartTimer = 4.0f;
        showCollectibles = false;
        originalCollectionPos = moveCollectibles.transform.position;

        playerStats = GameObject.FindGameObjectWithTag("GameController").GetComponent<PlayerStats>();
        animator = moveCollectibles.GetComponent<Animator>();
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
        scoreText.text = playerStats.LevelScore.ToString();

    

        if(timeSpent > collectibleTimer)
        {
            HideCollectibles();
        }

    }
    public void ShowCollectibles()
    {
        collectibleTimer = timeSpent + collectibleStartTimer;
        if (moveCollectibles != null)
        {
            if (animator != null)
            {
                animator.SetBool("open", true);
            }
        }
    }
    public void HideCollectibles()
    {
        if (moveCollectibles != null)
        {
            if (animator != null)
            {
                animator.SetBool("open", false);
            }
        }
    }
}
