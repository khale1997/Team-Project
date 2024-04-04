using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource musicSource;
    public AudioSource soundFXSource;

    public bool isMenuMusic = true;

    public AudioClip menu;
    public AudioClip background;
    public AudioClip explode;
    public AudioClip buttonClick;
    public AudioClip bulletHit;

    public float soundVolume = 1.0f;
    
    void Start()
    {
        musicSource.volume = soundVolume;
        soundFXSource.volume = soundVolume;

        musicSource.clip = menu;
        musicSource.loop = true;
        musicSource.Play();
    }

    void Update()
    {
        // menu and back ground music
        if (Input.GetKeyDown(KeyCode.Return)) {
            if (isMenuMusic) {
                musicSource.clip = background;
                musicSource.loop = true;
                musicSource.Play();
                isMenuMusic = false;
            } else {
                musicSource.clip = menu;
                musicSource.loop = true;
                musicSource.Play();
                isMenuMusic = true;
            }
        }

        // bullet hit
        if (Input.GetKeyDown(KeyCode.Space)) {
            soundFXSource.clip = bulletHit;
            soundFXSource.Play();
        }

        // explode
        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            soundFXSource.clip = explode;
            soundFXSource.Play();
        }

        // button click
        if (Input.GetKeyDown(KeyCode.DownArrow)) {
            soundFXSource.clip = buttonClick;
            soundFXSource.Play();
        }

        // stop the music
        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            if (musicSource.isPlaying)
            {
                musicSource.Stop();
            }
        }
    }   
}
