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


        StartCoroutine(PostData());
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
    IEnumerator PostData()
    {

        string uri = "http://sokroban.azurewebsites.net/Sokroban/SokSave?Username=Arthur&Level=7&Score=2000&Time=150";
        WWWForm form = new WWWForm();
        using (UnityWebRequest request = UnityWebRequest.Post(uri, form))
        {
            yield return request.SendWebRequest();
        }
    }
}
