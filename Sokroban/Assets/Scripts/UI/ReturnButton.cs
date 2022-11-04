using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Photon.Pun;

public class ReturnButton : MonoBehaviour
{
    public void OnReturnClick()
    {
        //Reset level
        GameManager.levelCounter = 1;
        //Reset game mode
        LevelTranslator.isSandbox = false;
        LevelTranslator.isNormal = false;
        LevelTranslator.isChallenge = false;
        LevelTranslator.isCoop = false;
        TimerCount.timer = 0.0f;
        //Disconnect
        PhotonNetwork.Disconnect();
        SceneManager.LoadScene("Main Menu");
    }
}
