using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deactive : MonoBehaviour
{
    [SerializeField] GameObject sphereLava1;
    [SerializeField] GameObject sphereLava2;
    [SerializeField] GameObject sphereLava3;
    [SerializeField] GameObject sphereYellow;
    [SerializeField] GameObject sphereWater;
    [SerializeField] GameObject wall1;
    [SerializeField] GameObject wall2;
    [SerializeField] GameObject wall3; 


 
    void Update()
    {
        if (GameManager.instance.IsLevelOneFinish)
        {
            wall1.SetActive(false);
            sphereLava1.SetActive(false);
            sphereLava2.SetActive(false);
            sphereLava3.SetActive(false);

        }
        if (GameManager.instance.IsLevelTwoFinish)
        {
            wall2.SetActive(false);
            sphereYellow.SetActive(false);

        }
        if (GameManager.instance.IsLevelThreeFinish)
        {
            wall3.SetActive(false);
            sphereWater.SetActive(false);

        }




    }
}
