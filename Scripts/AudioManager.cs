using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using System;

public class AudioManager : MonoBehaviour
{
    public Sound[] sounds;

    public static AudioManager instance;


    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(gameObject);

        int effect_mod = PlayerPrefs.GetInt("game.audio.effects");
        int music_mod = PlayerPrefs.GetInt("game.audio.music");

        foreach (Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
        }
    }

    public void Play (string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        if (s == null)
        {
            return;
        }
 


        s.source.Play();
    }

    public void StopPlaying (string sound)
    {
        Sound s = Array.Find(sounds, item => item.name == sound);
        if (s == null)
        {
            Debug.LogWarning("Sound: " + name + " not found!");
            return;
        }

        s.source.volume = s.volume * (1f + UnityEngine.Random.Range(-s.volumeVariance / 2f, s.volumeVariance / 2f));
        s.source.pitch = s.pitch * (1f + UnityEngine.Random.Range(-s.pitchVariance / 2f, s.pitchVariance / 2f));

        s.source.Stop();
    }


    void Start()
    {
        change_volume();
        //play_main_theme();
    }

    public void play_main_theme()
    {
        Play("Mountain_theme2");
    }


    public void change_volume()
    {
        foreach (Sound s in sounds)
        {

            Debug.Log($"volume is equal to { s.source.volume } for {s.source.name } ");
            if (s.audiotype == "effect")
            {
                float x = PlayerPrefs.GetInt("game.audio.effects");
                Debug.Log(x + "steve");
                s.source.volume = s.volume * (PlayerPrefs.GetFloat("game.audio.effects") / 100);

            }
            if (s.audiotype == "music")
            {
                s.source.volume = s.volume * (PlayerPrefs.GetFloat("game.audio.music") / 100);
            }

        }
    }


}
