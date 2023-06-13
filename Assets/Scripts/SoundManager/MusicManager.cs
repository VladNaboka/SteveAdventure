using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    [SerializeField] private Music[] _musicClips;
    public static MusicManager instance;
    private void Awake()
    {
        if (instance == null)
            instance = this;
        else
        {
            Destroy(gameObject);
            return;
        }
        DontDestroyOnLoad(gameObject);

        foreach (Music music in _musicClips)
        {
            music.source = gameObject.AddComponent<AudioSource>();
            music.source.gameObject.SetActive(true);
            music.source.clip = music.clip;
            music.source.volume = music.volume;
            music.source.pitch = music.pitch;
            //music.source.playOnAwake = true;
            //music.source.loop = true;
        }
        int randomNum = UnityEngine.Random.Range(1, 4);
        PlayMusic(randomNum);
    }
    private void Update()
    {
        //if(_)
    }

    private void PlayMusic(int musicNumber)
    {
        Music m = Array.Find(_musicClips, music => music.number == musicNumber);
        if (m == null)
        {
            Debug.LogWarning("Wrong sound name!");
            return;
        }
        m.source.Play();
    }
    private void PlayNext() 
    {
        int prevMusic;
    }
}
