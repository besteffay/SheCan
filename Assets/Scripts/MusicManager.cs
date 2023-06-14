using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    public static MusicManager musicManager;
    public AudioSource _audioSource;

    private void Awake()
    {
       
        //DontDestroyOnLoad(transform.gameObject);

        if(musicManager == null)
        {
            DontDestroyOnLoad(gameObject);
            musicManager = this;
        }
        else if(musicManager != this)
        {
            Destroy(gameObject);
        }

        _audioSource = GetComponent<AudioSource>();

    }

    public void PlayMusic()
    {
        if (_audioSource.isPlaying) return;
        _audioSource.Play();
    }

    public void StopMusic()
    {
        _audioSource.Stop();
    }
}
