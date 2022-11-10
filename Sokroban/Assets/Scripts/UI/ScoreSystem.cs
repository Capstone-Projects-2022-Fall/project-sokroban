using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreSystem : MonoBehaviour
{
    public static float totalScore = 0.0f;
    public float currentScore = 0.0f;
    public Text pointsText;

    public static int movesTaken = 0; //is set in the Player.cs

    public void UpdateScore()
    {
        float crateModifier = 1.0f + ((float)LevelTranslator.crates / 10.0f);//change this to tierModifier once tiers are setup
        float maxMovmentScore = 1000.0f * crateModifier;
        currentScore = ((float)((maxMovmentScore - (movesTaken * 10)) * crateModifier))/(float)(TimerCount.timer);//1000 should scale to each tier
        Debug.Log("Score: " + currentScore);
        if (currentScore < 50)
        {
            currentScore = 50;
        }
        totalScore += currentScore;
        movesTaken = 0; //resets moves
         
    }
    private void Update() 
    {
        pointsText.text = "Points: " + Math.Floor(totalScore);
        Debug.Log("Score is: " + totalScore);
    }
}
