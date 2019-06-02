using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine.Audio;
using UnityEngine;


public class AudioManager : MonoBehaviour
{
    public Sound[] soundList;

    
    // Start is called before the first frame update
    void Awake()
    {
        foreach(Sound s in soundList)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
        }
    }

    public void Play(string name)
    {
        Sound s = Array.Find(soundList, sound => sound.name == name);
        if(s == null)
        {
            return;
        }

        else if(s.name == "LevelTheme" || s.name == "FireLoop" || s.name == "FireBall")
        {
            s.source.loop = true;
            Debug.Log("play");
        }

        s.source.Play(0);

    }

    public void Stop(string name)
    {
        Sound s = Array.Find(soundList, sound => sound.name == name);
        if (s == null)
        {
            return;
        }
        s.source.Stop();

    }

    public void ChangeVolume(float volume, string name)
    {
        try
        {
            Sound s = Array.Find(soundList, sound => sound.name == name);
            s.volume = volume;
        }
        catch(Exception e)
        {
            Debug.Log(e.Message);
        }
    }
}
