using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBallSparks : MonoBehaviour
{
    public ParticleSystem idleSpark;
    public ParticleSystem chargeSpark;
    public Transform chargeSparkPos;

    private bool isCharging;

    // Update is called once per frame
    void Update()
    {
        if (Charging() || Input.GetKey(KeyCode.Keypad7))
        {
            chargeSpark.Play();
            idleSpark.Stop();

            ChargeSparkTransform();
        }
        else
        {
            chargeSpark.Stop();
            idleSpark.Play();
        }
    }

    private void ChargeSparkTransform()
    {
        chargeSpark.transform.eulerAngles = new Vector3(-90, 0, 0);
        chargeSpark.transform.position = chargeSparkPos.position;
    }

    private bool Charging()
    {
        if(isCharging)
        {
            chargeSpark.Play();
            idleSpark.Stop();
            return true;
        }
        else
        {
            idleSpark.Play();
            chargeSpark.Stop();
            return false;
        }
    }

    private void SetIsCharging(bool state)
    {
        isCharging = state;
    }
}
