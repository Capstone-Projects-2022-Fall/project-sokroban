using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Photon.Pun;
using UnityEngine.UI;
using UnityEngine.Networking;
using System.Net.Http;

public class ReturnButton : MonoBehaviour
{
    public void OnReturnClick()
    {
        string usr = "Art";
        int Scores = 2000;
        int Time = 150;
        int Level = 7;

        StartCoroutine(PostData(usr, Scores, Time, Level));
        //Reset level
        GameManager.levelCounter = 1;
        //Reset game mode
        LevelTranslator.isSandbox = false;
        LevelTranslator.isNormal = false;
        LevelTranslator.isChallenge = false;
        LevelTranslator.isCoop = false;
        LevelTranslator.isVS = false;
        TimerCount.timer = 0.0f;
        //Disconnect
        PhotonNetwork.Disconnect();
        SceneManager.LoadScene("Main Menu");
    }
    IEnumerator PostData(string usr, int Score, int Time, int Level)
    {

        string uri = "https://sokroban.azurewebsites.net/Sokroban/SokLevelInsert?Username=" + usr + "&Score=" + Score + "&Time=" + Time + "&Level=" + Level;
        WWWForm form = new WWWForm();
        form.AddField("Username", "");
        form.AddField("Score", "");
        form.AddField("Time", "");
        form.AddField("Level", "");
        using (UnityWebRequest request = UnityWebRequest.Post(uri, form))
        {
            yield return request.SendWebRequest();
        }
    }
}
