using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasPlay : MonoBehaviour
{

    [SerializeField] Text textTime; 
    [SerializeField] Text textPoints;

 
    
    void Update()
    {
        textTime.text = "TIME : " + GameManager.instance.MaxCounter.ToString();
        textPoints.text = "POINTS : " + GameManager.instance.TotalPoints.ToString();
    }
}
