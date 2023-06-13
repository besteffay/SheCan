using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource audioSource;

    [Header("UI Sound")]
    public AudioClip Buttonclicks;

    [Header(" Game Sound ")]
    public AudioClip walking;
    public AudioClip jumping;
    public AudioClip usingPowerUp;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void PlayClickSound()
    {
        audioSource.PlayOneShot(Buttonclicks);
    }

    public void PlayWalkSound()
    {
        audioSource.PlayOneShot(walking);
    }

    public void PlayJumpSound()
    {
        audioSource.PlayOneShot(jumping);
    }

    public void PlayActivtePowerSound()
    {
        audioSource.PlayOneShot(usingPowerUp);
    }

}
