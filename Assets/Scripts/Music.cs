using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    public AudioSource src;
    public AudioSource src2;
    public AudioClip song;

    bool sounding;

    void Start()
    {
        src = GetComponent<AudioSource>();
        song = Resources.Load<AudioClip>("song");
        src.clip = song;
        StartCoroutine(PlayIt());
        src.volume = volumeLevel.volume;
    }

    IEnumerator PlayIt()
    {
        if (!sounding)
        {
            yield return new WaitForSeconds(3f);
            src.Play();
            sounding = true;
        }
    }

    void Update()
    {
        if (BController.isPaused && sounding)
        {
            src.Pause();
        }
        else if (!BController.isPaused && sounding)
        {
            src.UnPause();
        }
        if (Score.youWin)
        {
            src.Stop();
        }
        if (Score.youLoose)
        {
            src.Stop();
        }

        if (Timer.estaescena == "tuto")
        {
            src.Stop();
        }
    }
}
