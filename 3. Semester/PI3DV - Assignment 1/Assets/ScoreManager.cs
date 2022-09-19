using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public int _score = 0;

    
    public static ScoreManager inst;

    public Text scoreText;

    public PlayerMovement _pm;

    public void Update() 
    {
        if(_score == 10)
        {
            scoreText.text = "SCORE: " + _score + " YOU WIN!";
            _pm._alive = false;
        }
    }
    //adds to the score and sets the UI
    //increment means add 1
    public void IncrementScore()
    {
        _score++;

        //this sets the text of the text element to score followed by or current score 
        scoreText.text = "SCORE: " + _score;
         
    }

    private void Awake() 
    {
        inst = this;
    }
}
