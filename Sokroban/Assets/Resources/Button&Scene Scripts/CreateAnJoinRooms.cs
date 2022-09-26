using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Photon.Pun;

public class CreateAnJoinRooms : MonoBehaviourPunCallbacks
{
    public InputField createInput;
    public InputField joinInput;

    public void CreateRoom()
    {
        if (string.IsNullOrEmpty(createInput.name))
        {
            return;
        }
        PhotonNetwork.CreateRoom(createInput.text);
        Debug.Log("Room \"" + createInput.text + "\" created");
    }

    public void JoinRoom()
    {
        if (string.IsNullOrEmpty(createInput.name))
        {
            return;
        }
        PhotonNetwork.JoinRoom(joinInput.text);
         Debug.Log("Room \"" + joinInput.text + "\" joined");
    }

    public override void OnJoinedRoom()
    {
        PhotonNetwork.LoadLevel("Level-Multiplayer");
    }

    public override void OnCreateRoomFailed(short returnCode, string message)
    {
        Debug.Log("Room Creation Failed" + message);
    }

    public override void OnJoinRoomFailed(short returnCode, string message)
    {
        Debug.Log("Room Join Failed" + message);
    }

    public void LeaveRoom()
    {
        PhotonNetwork.LeaveRoom();
    }

    public override void OnLeftRoom()
    {
        SceneManager.LoadScene("Loading");
    }

}
