using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static AudioClip jumpSound, deathSound, gameSound;
    static AudioSource audioSrc;
    public AudioSource levelMusic;
    public AudioSource deathEffect;

    public bool levelSong = true;
    public bool deathSong = false;
    // Start is called before the first frame update
    void Start()
    {
        jumpSound = Resources.Load<AudioClip>("jumpSound");
        deathSound = Resources.Load<AudioClip>("deathSound");
        gameSound = Resources.Load<AudioClip>("gameSound");

        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LevelMusic()
    {
        levelSong = true;
        deathSong = false;
        levelMusic.Play();
    }

    public void DeathSound()
    {
        if (levelMusic.isPlaying)
            levelSong = false;

        levelMusic.Stop();

        if(!deathEffect.isPlaying && deathSong == false)
        {
            deathEffect.Play();
            deathSong = true;
        }
    }

    public static void PlaySound (string clip)
    {
        switch (clip)
        {
            case "jumpSound":
                audioSrc.PlayOneShot(jumpSound);
                break;
        }
    }
}
