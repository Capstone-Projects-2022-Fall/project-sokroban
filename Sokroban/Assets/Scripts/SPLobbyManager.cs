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

    public void OnSubmitClick()
    {
        if (string.IsNullOrEmpty(numBoxes.text) || Convert.ToInt32(numBoxes.text) < 1)
        {
            errorText.text = "Input valid number of boxes!";
            Debug.Log("Bad input");
            return;
        } 
        else {
            //Get the input, modify it to an int and pass it as argument in the level generator method. 
            SceneManager.LoadScene("SPLevel");
            Debug.Log("Entered Game Scene");
        }
    }

    public int getCrates()
    {
        Debug.Log(numBoxes.text+" crates spawned");
        return Convert.ToInt32(numBoxes.text);
    }
}
