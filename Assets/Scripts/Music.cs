using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    public AudioSource src;
    public AudioClip song;

    bool sounding;

    void Start()
    {
        src = GetComponent<AudioSource>();
        song = Resources.Load<AudioClip>("song");
        src.clip = song;
        StartCoroutine(PlayIt());
    }

    IEnumerator PlayIt()
    {
        if (!sounding)
        {
            yield return new WaitForSeconds(3.1f);
            src.Play();
            sounding = true;
        }
    }
}
