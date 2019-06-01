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
        scoreAmount.alignment = TextAnchor.UpperLeft;
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
            if(timeBonusAdded > 0)
            {
                timeBonusAdded--;
                timeBonusAmount.text = timeBonusAdded.ToString();
                totalScoreValue++;
            }
            
            if(ingameScoreValue > 0)
            {
                if(ingameScoreValue > 500)
                {
                    ingameScoreValue -= 5;
                    totalScoreValue += 5;
                }
                else
                {
                    ingameScoreValue--;
                    totalScoreValue++;
                }

                scoreAmount.text = ingameScoreValue.ToString();

            }
            yield return new WaitForSeconds(.005f);
            totalScoreAmount.text = totalScoreValue.ToString();

        }
    }

    private IEnumerator AnimateIncreaseTimeBonus()
    {
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
}
