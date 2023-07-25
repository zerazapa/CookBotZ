using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sounds : MonoBehaviour
{
    public AudioSource src;
    public AudioClip felicidades, lastima;

    private bool isWinSoundPlayed = false;
    private bool isLoseSoundPlayed = false;

    void Start()
    {
        src = GetComponent<AudioSource>();
        felicidades = Resources.Load<AudioClip>("felicidades");
        lastima = Resources.Load<AudioClip>("lastima");
    }

    void Update()
    {
        src.volume = volumeLevel.volume;
        
        if (Score.youWin && !isWinSoundPlayed)
        {
            src.clip = felicidades;
            src.Play();
            isWinSoundPlayed = true;
        }
        if (Score.youLoose && !isLoseSoundPlayed)
        {
            src.clip = lastima;
            src.Play();
            isLoseSoundPlayed = true;
        }
    }
}