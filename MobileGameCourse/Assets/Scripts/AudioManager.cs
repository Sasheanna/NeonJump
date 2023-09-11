using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 *  "Attribution" for the music (include in game?)
 *  Music: Bensound.com/royalty-free-music
 *  License code: RRBMZYY9GRM8ARDF
 *
 */

public class AudioManager : MonoBehaviour
{
    public AudioSource Music, DieSE, JumpSE;

    void Start()
    {
        PlayMusic();
    }

    public void PlayMusic()
    {
        Music.Play();
    }

    public void PlayDie()
    {
        DieSE.Play();
    }
    public void PlayJump()
    {
        JumpSE.Play();
    }
}
