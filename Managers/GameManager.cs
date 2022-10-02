using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;


    //Difficulty 

    private float _difficultyDefault = 5f;
  
    public float DifficultyDefault { get { return _difficultyDefault; } set { _difficultyDefault = value; } }

    //Points ******************************************* 

    private int _totalPoints = 0; 

    public int TotalPoints { get { return _totalPoints; } set { _totalPoints = value; } }

    //Counter ********************************************** 

    private int _maxCounter = 20;
    private bool _counter = true; 

    public int MaxCounter { get { return _maxCounter; } set { _maxCounter = value; } }

    //Levels ************************************************ 

    private bool _isLevelOneFinish = false;
    private bool _isLevelTwoFinish = false;
    private bool _isLevelThreeFinish = false; 

    public bool IsLevelOneFinish { get { return _isLevelOneFinish; } set { _isLevelOneFinish = value; } } 
    public bool IsLevelTwoFinish { get { return _isLevelTwoFinish; } set { _isLevelTwoFinish = value; } } 
    public bool IsLevelThreeFinish { get { return _isLevelThreeFinish; } set { _isLevelThreeFinish = value; } }

    //Record ************************************************ 
    private int _record = 0; 

    public int Record { get { return _record; } set { _record = value; } } 

    //************************************************************************** 

    private void Awake()
    {
        if (GameManager.instance == null)
        {
            GameManager.instance = this;
            DontDestroyOnLoad(GameManager.instance);
        }
        else
        {
            Destroy(GameManager.instance);
        }
    }

    void Start()
    {
        _record = PlayerPrefs.GetInt("Record", _totalPoints);
    }

    // Update is called once per frame
    void Update()
    {
        checkLevels();
    } 

    public void counterFunction()
    {
        if (_counter) _maxCounter--;
        if (!_counter) _maxCounter = 0;

    }

    public void checkLevels()
    {
        if(_maxCounter <= 0 && !_isLevelOneFinish)
        {
            _isLevelOneFinish = true;
            _maxCounter = 20;
   
        }
        if (_maxCounter <= 0 && !_isLevelTwoFinish)
        {
            _isLevelTwoFinish = true;
            _maxCounter = 20;
    
        }
        if (_maxCounter <= 0 && !_isLevelThreeFinish)
        {
            _isLevelThreeFinish = true;
            _counter = false;
            _maxCounter = 0;
       
        }
    }


    //Total points  

     public void totalPointsFunction()
    {
        _totalPoints += 1;
     
    }

    //Record  
    public void RecordFunction()
    {
        if (_totalPoints > PlayerPrefs.GetInt("Record"))
        {
            PlayerPrefs.SetInt("Record", _totalPoints);
        }
    }

}
