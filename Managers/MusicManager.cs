using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{

    public static MusicManager instance;

    AudioSource _mainMenu;
    AudioSource _play;
    AudioSource _final;

    private void Awake()
    {
        if (MusicManager.instance == null)
        {
            MusicManager.instance = this;
            DontDestroyOnLoad(this);
            _mainMenu = GameObject.FindGameObjectWithTag("MainMenu").GetComponent<AudioSource>();
            _play = GameObject.FindGameObjectWithTag("Play").GetComponent<AudioSource>();
            _final = GameObject.FindGameObjectWithTag("Final").GetComponent<AudioSource>();
        }
        else
        {
            Destroy(MusicManager.instance);
        }
    }




    //play  

    public void playMainMenu() => _mainMenu.Play();
    public void playPlayMusic() => _play.Play();
    public void playFinalMusic() => _final.Play();


    //pause

    public void pauseMainMenu() => _mainMenu.Pause();
    public void pausePlayMusic() => _play.Pause();
    public void pauseFinalMusic() => _final.Pause();
 
}
