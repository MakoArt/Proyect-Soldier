using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FinalCanvas : MonoBehaviour
{
    [SerializeField] Text textRecord;
    [SerializeField] Text textPoints; 
    
    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        textRecord.text = "TOTAL SESSIONS RECORD : " + GameManager.instance.Record.ToString();
        textPoints.text = "THIS SESSION POINTS : " + GameManager.instance.TotalPoints.ToString();
    }

    
    public void GoToMainMenu()
    {
        MusicManager.instance.pauseFinalMusic();
        SceneManager.LoadScene("MainMenu");
        Destroy(GameManager.instance);
    }
    public void DeleteRecord()
    {
        PlayerPrefs.DeleteKey("Record");
    }
}
