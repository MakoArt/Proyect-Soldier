using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlay : MonoBehaviour
{
 
    void Start()
    {
        MusicManager.instance.pauseMainMenu(); 
        MusicManager.instance.playPlayMusic();
    }

    
}
