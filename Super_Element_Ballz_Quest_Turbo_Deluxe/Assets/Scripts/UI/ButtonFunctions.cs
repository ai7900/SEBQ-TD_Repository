using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonFunctions : MonoBehaviour
{
    //This class is mainly for use together with animation events.
    
    private void PlaySound(string name)
    {
        AudioManager.Play(name);
    }
}
