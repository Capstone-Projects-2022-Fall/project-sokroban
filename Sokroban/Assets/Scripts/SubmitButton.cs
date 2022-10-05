using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SubmitButton : MonoBehaviour
{
    public InputField numBoxes;
    public Text errorText;

    public void OnSubmitClick()
    {

        if (string.IsNullOrEmpty(numBoxes.text))
        {
            errorText.text = "Input number of boxes!";
            Debug.Log("No input");
            return;
        } 
        else {
            //Get the input, modify it to an int and pass it as argument in the level generator method. 
            SceneManager.LoadScene("Temp");
            Debug.Log("Entered Temp Scene");
        }
    }
}
