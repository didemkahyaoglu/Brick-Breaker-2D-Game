using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance;
    [SerializeField] private AudioSource soundFX;
    [SerializeField] private AudioClip  bgClip,HitClip;

    void Start()
    {
        if (instance == null)
            instance = this;
    }

    
    public void BGSound()
    {
        soundFX.clip = bgClip;
        soundFX.Play();
    }

    public void HitSound()
    {
        soundFX.clip = HitClip;
        soundFX.Play();
    }


}
