using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CanvasMain : MonoBehaviour
{

    public void GoToPlay() => SceneManager.LoadScene("SampleScene");
}
