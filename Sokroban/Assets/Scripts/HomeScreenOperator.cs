using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class HomeScreenOperator : MonoBehaviour
{
    public void OnClickLogin()
    {
        SceneManager.LoadScene("Main Menu");
        Debug.Log("Entered Main Menu");
    }

    public void OnClickSignUp()
    {
        SceneManager.LoadScene("Main Menu"); 
        Debug.Log("Entered Main Menu");
    }
}