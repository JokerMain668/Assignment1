using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusic : MonoBehaviour
{
    // Start is called before the first frame update

    public AudioSource Audio;
    public AudioClip Intro;
    public AudioClip Normal;
    bool finished = false;

    private float introClipLength;
    void Start()
    {
        Audio.clip = Intro;
        Audio.PlayOneShot(Intro, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= Intro.length && finished == false)
        {
            finished = true;
            Audio.clip = Normal;
            Audio.loop = true;
            Audio.Play();
        }
    }
}
