using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Debug = UnityEngine.Debug;

public class HomeScreenManager : MonoBehaviour
{
    public InputField usernameInput;
    public InputField passwordInput;
    public Text errorText;



    public void OnClickLogin()
    {
        if (string.IsNullOrEmpty(usernameInput.text) || string.IsNullOrEmpty(passwordInput.text))
        {
            errorText.text = "Input Username and Password!";
            Debug.Log("Bad credentials");
            return;
        } 
        else {
            
            SceneManager.LoadScene("Main Menu");
            Debug.Log("Entered Main Menu");
        }
    }
    public void OnClickGuest()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void OnClickSignUp()
    {
        if (string.IsNullOrEmpty(usernameInput.text) || string.IsNullOrEmpty(passwordInput.text))
        {
            errorText.text = "Input Username and Password!";
            Debug.Log("Bad credentials");
            return;
        } 
        else {
            SceneManager.LoadScene("Main Menu"); 
            Debug.Log("Entered Main Menu");
        }
    }
}