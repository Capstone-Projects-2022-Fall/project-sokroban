using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    public static bool isMultiplayer;
    public void OnClickSinglePlay()
    {
        isMultiplayer = false ;
        SceneManager.LoadScene("Singleplayer Lobby");
        Debug.Log("Entered single player lobby");
    }
    public void OnClickMultiPlay()
    {
        isMultiplayer = true;
        SceneManager.LoadScene("Loading"); //This will lead to multiplayer lobby scene
        Debug.Log("Entered loading screen");
    }
    public void OnClickLeaderboard()
    {
        SceneManager.LoadScene("Leaderboard");
        Debug.Log("Entered Leaderboard Screen");
    }
    public void OnClickExit()
    {
        Application.Quit();
        Debug.Log("Quit Game");
    }

}
