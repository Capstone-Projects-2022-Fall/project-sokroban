using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SPLobbyManager : MonoBehaviour
{
    public InputField numBoxes;
    public Text errorText;

    public void nextSandboxModeBtnClick()
    {
        LevelTranslator.isSandbox = true;
    }
    public void nextNormalModeBtnClick()
    {
        LevelTranslator.isNormal = true;
    }
    public void nextChallengeModeBtnClick()
    {
        LevelTranslator.isChallenge = true;
    }
    public void OnSubmitClick()
    {
        if ((LevelTranslator.isSandbox)&&(string.IsNullOrEmpty(numBoxes.text) || Convert.ToInt32(numBoxes.text) < 1 || Convert.ToInt32(numBoxes.text) > 10))
        {
            errorText.text = "Input valid number of boxes! (Min:1 Max:10)";
            Debug.Log("Bad input");
            return;
        } 
        else {
            //Get the input, modify it to an int and pass it as argument in the level generator method. 
            ScoreSystem.totalScore = 0.0f;
            SceneManager.LoadScene("SPLevel");
            LevelTranslator.crates = Convert.ToInt32(numBoxes.text);
            Debug.Log("Entered Game Scene");
        }
    }
}
