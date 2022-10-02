using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CanvasOption : MonoBehaviour
{
    [SerializeField] Slider slider;
    
    void Start()
    {
        Cursor.lockState = CursorLockMode.None; 
    }

    
    public void SaveData()
    {
        float data = slider.value;
        PlayerPrefs.SetFloat("Difficulty", data);

    } 
    public void GoToPlay()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void GoToMainMenu()
    {
        MusicManager.instance.pausePlayMusic();
        SceneManager.LoadScene("Final");
    }
}
