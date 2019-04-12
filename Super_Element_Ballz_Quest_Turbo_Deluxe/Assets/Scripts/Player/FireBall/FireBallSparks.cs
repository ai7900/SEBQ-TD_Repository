using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBallSparks : MonoBehaviour
{
    public GameObject idleSpark;
    public GameObject ChargeSpark;
    public Transform ChargeSparkPos;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Keypad7))
        {
            ChargeSpark.SetActive(true);
            idleSpark.SetActive(false);

            ChargeSparkTransform();
        }
        else
        {
            ChargeSpark.SetActive(false);
            idleSpark.SetActive(true);
        }
    }

    private void ChargeSparkTransform()
    {
        ChargeSpark.transform.eulerAngles = new Vector3(-90, 0, 0);
        ChargeSpark.transform.position = ChargeSparkPos.position;
    }
}
