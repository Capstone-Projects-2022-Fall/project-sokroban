using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Photon.Pun;
using Photon.Realtime;

public class ConnectionToServer : MonoBehaviourPunCallbacks
{
    bool connectedToServer = false;
    // Start is called before the first frame update
    void Start()
    {
        if (!connectedToServer)
        {
            //PhotonNetwork.NickName = username;
            PhotonNetwork.ConnectUsingSettings();

            Debug.Log("Connecting to Master");
        }
    }

    public override void OnConnectedToMaster()
    {
        PhotonNetwork.JoinLobby();
    }
    public override void OnJoinedLobby()
    {
        SceneManager.LoadScene("Multiplayer Lobby");
        Debug.Log("Joined multiplayer Lobby");
    }
   
    public override void OnDisconnected(DisconnectCause cause)
    {
        Debug.Log("Disconnected because" +cause.ToString());
        SceneManager.LoadScene("Main Menu");
    }
}
