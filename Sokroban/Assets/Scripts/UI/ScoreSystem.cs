using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreSystem : MonoBehaviour
{
    public static float totalScore = 0.0f;
    public Text pointsText;

    public static int movesTaken = 0; //is set in the Player.cs

    public void UpdateScore()
    {
        float crateModifier = 1.0f + ((float)LevelTranslator.crates / 10.0f);//change this to tierModifier once tiers are setup
        totalScore += ((float)(1000 - (movesTaken * 20)) * ((float)TimerCount.timer / 100.0f) * crateModifier);
        if (totalScore < 100)
        {
           totalScore = 100;
        }
        movesTaken = 0; //resets moves
         
    }
    private void Update() 
    {
        pointsText.text = "Points: " + Math.Floor(totalScore);
        Debug.Log("Score is: " + totalScore);
    }
}
