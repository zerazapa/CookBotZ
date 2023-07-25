using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffects : MonoBehaviour
{
    public AudioSource src;
    public AudioClip victory, loss;

    private bool isWinSoundPlayed = false;
    private bool isLoseSoundPlayed = false;

    void Start()
    {
        src = GetComponent<AudioSource>();
        victory = Resources.Load<AudioClip>("victory");
        loss = Resources.Load<AudioClip>("loss");
    }

    void Update()
    {        
        if (Score.youWin && !isWinSoundPlayed)
        {
            src.clip = victory;
            src.Play();
            isWinSoundPlayed = true;
            src.volume = volumeLevel.volume * .4f;
        }
        if (Score.youLoose && !isLoseSoundPlayed)
        {
            src.clip = loss;
            src.Play();
            isLoseSoundPlayed = true;
            src.volume = volumeLevel.volume;
        }
    }
}
