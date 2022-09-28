using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuOperator : MonoBehaviour
{
    public void OnClickPlay()
    {
        SceneManager.LoadScene("Loading");
        Debug.Log("Entered Play Screen");
    }
    public void OnClickLeaderboard()
    {
        //SceneManager.LoadScene("Leaderboard");
        Debug.Log("Entered Leaderboard Screen");
    }
    public void OnClickExit()
    {
        Application.Quit();
        Debug.Log("Quit Game");
    }

}
