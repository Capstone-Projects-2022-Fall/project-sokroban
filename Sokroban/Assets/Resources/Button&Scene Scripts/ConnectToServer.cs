using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Photon.Pun;
using Photon.Realtime;

public class ConnectToServer : MonoBehaviourPunCallbacks
{
    // Start is called before the first frame update
    void Start()
    {
        //PhotonNetwork.NickName = username;
        PhotonNetwork.ConnectUsingSettings();
        Debug.Log("Connecting to Master");
    }

    public override void OnConnectedToMaster()
    {
        PhotonNetwork.JoinLobby();
    }
    public override void OnJoinedLobby()
    {
        SceneManager.LoadScene("Lobby");
        Debug.Log("Joined Lobby");
    }
    public override void OnDisconnected(DisconnectCause cause)
    {
        Debug.Log("Disconnected because" +cause.ToString());
    }
}
