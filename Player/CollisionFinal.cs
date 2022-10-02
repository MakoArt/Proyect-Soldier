using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionFinal : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
       
        if (other.CompareTag("FinalWall"))
        {
            GameManager.instance.RecordFunction();
            SceneManager.LoadScene("Final");
        }
    }


   
}
