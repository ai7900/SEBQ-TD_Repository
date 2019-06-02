﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelComplete : MonoBehaviour
{
    private PlayerStats playerStats;

    [SerializeField]
    private Text ingameScoreAmount;
    [SerializeField]
    private Text scoreAmount;
    [SerializeField]
    private Text timeBonusAmount;
    [SerializeField]
    private Text totalScoreAmount;

    private int timeBonusAdded = 0;

    private int totalScoreTarget;
    private static int totalScoreValue;
    private int ingameScoreValue;

    private static int previousTotalScore;

    [SerializeField]
    private Button contButton;
    [SerializeField]
    private Button menuButton;

    private Animator animator;

    private void Awake()
    {
        animator = gameObject.GetComponent<Animator>();
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        playerStats = GameObject.FindGameObjectWithTag("GameController").GetComponent<PlayerStats>();
        scoreAmount.text = ingameScoreAmount.text;
        ingameScoreValue = playerStats.LevelScore;
        timeBonusAmount.text = "0";
        totalScoreAmount.text = previousTotalScore.ToString();
        totalScoreTarget = PlayerStats.TotalScore;
        scoreAmount.alignment = TextAnchor.UpperLeft;
        totalScoreValue = previousTotalScore;
    }

    // Update is called once per frame
    private void Update()
    {
        
    }

    private void StartAnimations()
    {
        StartCoroutine(AnimateIncreaseTimeBonus());
    }

    private IEnumerator AnimateTotalScore()
    {
        yield return new WaitForSeconds(.5f);
            StartCoroutine(PlayScoreTick());
            while (totalScoreAmount.text != totalScoreTarget.ToString())
            {
            if (timeBonusAdded > 0)
            {
                if (timeBonusAdded > 500)
                {
                    timeBonusAdded -= 15;
                    totalScoreValue += 15;
                }
                else if (timeBonusAdded > 200)
                {
                    timeBonusAdded -= 100;
                    totalScoreValue += 100;
                }
                else
                {
                    timeBonusAdded--;
                    totalScoreValue++;
                }
                timeBonusAmount.text = timeBonusAdded.ToString();
            }

            if (ingameScoreValue > 0)
            {
                if (ingameScoreValue > 500)
                {
                    ingameScoreValue -= 15;
                    totalScoreValue += 15;
                }
                else if(ingameScoreValue > 2000)
                {
                    ingameScoreValue -= 100;
                    totalScoreValue += 100;
                }
                else
                {
                    ingameScoreValue--;
                    totalScoreValue++;
                }
            }

            else if (ingameScoreValue < 0)
            {
                if(ingameScoreValue < -500)
                {
                    ingameScoreValue += 15;
                    totalScoreValue -= 15;
                }
                else if (ingameScoreValue > 2000)
                {
                    ingameScoreValue += 100;
                    totalScoreValue -= 100;
                }
                else
                {
                    ingameScoreValue++; ;
                    totalScoreValue--;
                }
            }
            scoreAmount.text = ingameScoreValue.ToString();
            yield return new WaitForSeconds(.005f);
            totalScoreAmount.text = totalScoreValue.ToString();

            }
        
        previousTotalScore = totalScoreValue;
        animator.enabled = false;
        contButton.interactable = true;
        menuButton.interactable = true;
    }

    private IEnumerator AnimateIncreaseTimeBonus()
    {
        StartCoroutine(PlayTimeTick());
        while (timeBonusAmount.text != playerStats.TimeBonus.ToString())
        {

            timeBonusAdded++;
            timeBonusAmount.text = timeBonusAdded.ToString();
            yield return new WaitForSeconds(.005f);
        }

        StartCoroutine(AnimateTotalScore());

        yield return 0;
    }

    private void PlaySound(string sound)
    {
        AudioManager.Play(sound);
    }

    private IEnumerator PlayScoreTick()
    {
        while (totalScoreAmount.text != totalScoreTarget.ToString())
        {
            PlaySound("ScoreTick");
            yield return new WaitForSeconds(.075f);
        }
    }

    private IEnumerator PlayTimeTick()
    {
        while (timeBonusAmount.text != playerStats.TimeBonus.ToString())
        {
            PlaySound("TimeBonusTick");
            yield return new WaitForSeconds(.075f);
        }
    }
}
