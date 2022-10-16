using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Photon.Pun;

public class ReturnButton : MonoBehaviour
{
    public void OnReturnClick()
    {
        PhotonNetwork.Disconnect();
        SceneManager.LoadScene("Main Menu");
    }
}
