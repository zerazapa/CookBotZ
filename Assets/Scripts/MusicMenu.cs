using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicMenu : MonoBehaviour
{
    public AudioSource src;
    public AudioClip song;

    bool sounding;

    void Start()
    {
        src = GetComponent<AudioSource>();
        song = Resources.Load<AudioClip>("title");
        src.clip = song;
        src.Play();
        src.volume = volumeLevel.volume;
    }
    
    void Update()
    {
        src.volume = volumeLevel.volume;
    }
}
