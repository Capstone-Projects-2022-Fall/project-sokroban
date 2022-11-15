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
    string usr = "SokUsr";
    int Scores = 500;
    int Time = 120;
    int Level = 5;


    public void OnReturnClick()
    {
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
        StartCoroutine(PostData(usr, Scores, Time, Level));
        SceneManager.LoadScene("Main Menu");
    }



    IEnumerator PostData(string usr, int Score, int Time, int Level)
    {

        string uri = "https://sokroban.azurewebsites.net/Sokroban/SokLevelInsert??Username=" + usr + "&Score=" + Score + "&Time=" + Time + "&level=" + Level;
        WWWForm form = new WWWForm();
        //form.AddField("Username", "");
        //form.AddField("Password", "");
        using (UnityWebRequest request = UnityWebRequest.Post(uri, form))
        {
            yield return request.SendWebRequest();
        }
    }
}
