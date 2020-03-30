﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{
    public static AudioClip explosionSound;
    public static AudioClip menuSound;
    public static AudioClip impactSound;
    static AudioSource audioSrc;

    // Start is called before the first frame update
    void Start()
    {
        explosionSound = Resources.Load<AudioClip>("musket_explosion");
        menuSound = Resources.Load<AudioClip>("menu");
        impactSound = Resources.Load<AudioClip>("impact");
        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "explosion":
                audioSrc.PlayOneShot(explosionSound);
                break;
            case "menu":
                audioSrc.PlayOneShot(menuSound);
                break;
            case "impact":
                audioSrc.PlayOneShot(impactSound);
                break;
        }
    }
}
