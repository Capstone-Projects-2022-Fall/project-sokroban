using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Photon.Pun;

public class ReturnButton : MonoBehaviour
{
    public void OnReturnClick()
    {
        GameManager.levelCounter = 1;
        PhotonNetwork.Disconnect();
        SceneManager.LoadScene("Main Menu");
    }
}
