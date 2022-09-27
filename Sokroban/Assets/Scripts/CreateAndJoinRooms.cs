using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Photon.Pun;

public class CreateAndJoinRooms : MonoBehaviourPunCallbacks
{
    public InputField createInput;
    public InputField joinInput;

    public Text errorText;

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
        errorText.text = "Room Creation Failed: " + message;
        Debug.Log("Room Creation Failed: " + message);
        createInput.text = "";
    }

    public override void OnJoinRoomFailed(short returnCode, string message)
    {
        errorText.text = "Room Join Failed: " + message;
        Debug.Log("Room Join Failed: " + message);

        joinInput.text = "";
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
