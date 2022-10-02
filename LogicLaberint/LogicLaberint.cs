using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LogicLaberint : MonoBehaviour
{

    [SerializeField] GameObject lavaBall1; 
    [SerializeField] GameObject lavaBall2;
    [SerializeField] GameObject lavaBall3;
    [SerializeField] Animator lavaBallAnim1;
    [SerializeField] Animator lavaBallAnim2;
    [SerializeField] Animator lavaBallAnim3;
    [SerializeField] Animator yellowBallAnim; 
    [SerializeField] Animator waterBallAnim;

   
    


    void Start()
    {

      

        float speedBalls = PlayerPrefs.GetFloat("Difficulty");

        lavaBallAnim1.speed = GameManager.instance.DifficultyDefault + speedBalls; 
        lavaBallAnim2.speed = GameManager.instance.DifficultyDefault + speedBalls;
        lavaBallAnim3.speed = GameManager.instance.DifficultyDefault + speedBalls;
        yellowBallAnim.speed = GameManager.instance.DifficultyDefault + speedBalls;
        waterBallAnim.speed = GameManager.instance.DifficultyDefault + speedBalls; 



        InvokeRepeating("random", 0, 5);
        InvokeRepeating("counter", 1, 1);
    
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.O)) SceneManager.LoadScene("Options");
    }
    public void counter()
    {
        GameManager.instance.counterFunction();
    }

    public void random()
    {
        int randomBall = Random.Range(0, 3);

        if (randomBall == 0)
        {
            lavaBall1.SetActive(true);
            lavaBall2.SetActive(false);
            lavaBall3.SetActive(false);
        }
        if (randomBall == 1)
        {
            lavaBall1.SetActive(false);
            lavaBall2.SetActive(true);
            lavaBall3.SetActive(false);
        }
        if (randomBall == 2)
        {
            lavaBall1.SetActive(false);
            lavaBall2.SetActive(false);
            lavaBall3.SetActive(true);
        }
    }
}
