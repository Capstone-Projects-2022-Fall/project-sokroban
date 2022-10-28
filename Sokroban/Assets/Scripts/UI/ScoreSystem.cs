using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreSystem : MonoBehaviour
{
    public float totalScore = 1.0f;
    public Text pointsText;

    public static int movesTaken = 0;//is set in the Player.cs

    public void UpdateScore()
    {
        float crateModifier = 1.0f + ((float)LevelTranslator.crates / 10.0f);//change this to tierModifier once tiers are setup
        totalScore += ((float)(1000 - (movesTaken * 20)) * ((float)TimerCount.timer / 100.0f) * crateModifier);
     
        movesTaken = 0;//resets moves
        pointsText.text = "Points: " + totalScore.ToString();
    }
}
