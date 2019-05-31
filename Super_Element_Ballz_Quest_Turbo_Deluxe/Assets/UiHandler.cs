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
    Animator animator;

    private static float timeSpent;

    private string minutes;
    private string seconds;
    void Start()
    {
        collectibleStartTimer = 4.0f;
        showCollectibles = false;
        originalCollectionPos = moveCollectibles.transform.position;
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
