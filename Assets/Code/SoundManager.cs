using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static AudioClip jumpSound, deathSound, gameSound;
    static AudioSource audioSrc;
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

    public static void PlaySound (string clip)
    {
        switch (clip)
        {
            case "jumpSound":
                audioSrc.PlayOneShot(jumpSound);
                break;
            case "deathSound":
                audioSrc.PlayOneShot(deathSound);
                break;
            case "gameSound":
                audioSrc.PlayOneShot(gameSound);
                break;
            case "gameOver":
                audioSrc.Pause();
                break;
            case "newGame":
                audioSrc.Play();
                break;
        }
    }
}
