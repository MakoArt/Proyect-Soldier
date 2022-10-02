using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioFinal : MonoBehaviour
{
   
    void Start()
    {
        MusicManager.instance.pausePlayMusic();
        MusicManager.instance.playFinalMusic();
    }

 
}
