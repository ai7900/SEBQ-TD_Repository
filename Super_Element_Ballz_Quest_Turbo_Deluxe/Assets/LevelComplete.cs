using System.Collections;
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
    private int totalScoreValue = 0;
    private int ingameScoreValue;

    private void Awake()
    {
        playerStats = GameObject.FindGameObjectWithTag("GameController").GetComponent<PlayerStats>();
        scoreAmount.text = ingameScoreAmount.text;
        ingameScoreValue = playerStats.LevelScore;
        timeBonusAmount.text = "0";
        totalScoreAmount.text = "0";
        totalScoreTarget = PlayerStats.TotalScore;
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
        yield return new WaitForSeconds(2);

        if (totalScoreAmount.text != totalScoreTarget.ToString())
        {
            if(timeBonusAdded > 0)
            {
                timeBonusAdded--;
                timeBonusAmount.text = timeBonusAdded.ToString();
                totalScoreValue++;
            }
            
            if(ingameScoreValue > 0)
            {
                ingameScoreValue--;
                scoreAmount.text = ingameScoreValue.ToString();
                totalScoreValue++;
            }

            totalScoreAmount.text = totalScoreValue.ToString();

        }

        yield return 0;
    }

    private IEnumerator AnimateIncreaseTimeBonus()
    {
        if (timeBonusAmount.text != playerStats.TimeBonus.ToString())
        {
            timeBonusAdded++;
            timeBonusAmount.text = timeBonusAdded.ToString();
        }
        else
        {
            StartCoroutine(AnimateTotalScore());
        }

        yield return 0;
    }

}
