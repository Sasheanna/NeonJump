using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Menu : MonoBehaviour
{
    public TextMeshProUGUI title, score, highscore;
    public Button play, music, sound;
    public bool audioBool, musicBool;
    public AudioManager audiomanage;

    public void ChangeMenu(bool x)
    {

        //When x is TRUE, the main menu will appear
        title.gameObject.SetActive(x);
        play.gameObject.SetActive(x);
        music.gameObject.SetActive(x);
        sound.gameObject.SetActive(x);

        //When x is FALSE, the score and high score will appear
        score.gameObject.SetActive(!x);
        highscore.gameObject.SetActive(!x);
    }

    public void ChangeAudio()
    {
        audioBool = !audioBool;
        audiomanage.DieSE.mute = audioBool;
        audiomanage.JumpSE.mute = audioBool;
    }
    public void ChangeMusic()
    {
        musicBool = !musicBool;
        audiomanage.Music.mute = musicBool;
    }

}
