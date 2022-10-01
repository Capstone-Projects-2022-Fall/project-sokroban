using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Photon.Pun;

public class CreateAndJoinRooms : MonoBehaviourPunCallbacks
{
    public InputField roomInput;

    public Text errorText;

    public Toggle coopToggle;
    public Toggle versusToggle;

    bool firstToggleOn = false;
    public void CreateRoom()
    {
        if (string.IsNullOrEmpty(roomInput.name))
        {
            return;
        }
        PhotonNetwork.CreateRoom(roomInput.text);
        Debug.Log("Room \"" + roomInput.text + "\" created");
    }

    public void JoinRoom()
    {
        if (string.IsNullOrEmpty(roomInput.name))
        {
            return;
        }
        PhotonNetwork.JoinRoom(roomInput.text);
        Debug.Log("Room \"" + roomInput.text + "\" joined");
    }

    public override void OnJoinedRoom()
    {
        if (coopToggle.isOn)
        {
            PhotonNetwork.LoadLevel("Level-Multiplayer"); //Needs coop config
        }
        else if (versusToggle.isOn)
        {
            PhotonNetwork.LoadLevel("Level-Multiplayer"); //Needs versus config
        }
    }

    public override void OnCreateRoomFailed(short returnCode, string message)
    {
        errorText.text = "Room Creation Failed: " + message;
        Debug.Log("Room Creation Failed: " + message);
        roomInput.text = "";
    }

    public override void OnJoinRoomFailed(short returnCode, string message)
    {
        errorText.text = "Room Join Failed: " + message;
        Debug.Log("Room Join Failed: " + message);

        roomInput.text = "";
    }

    public void CheckToggles()
    {
        if (coopToggle.isOn && !firstToggleOn)
        {
            versusToggle.isOn = false;
            firstToggleOn = true;
        }
        if (versusToggle.isOn)
        {
            coopToggle.isOn = false;
            firstToggleOn = false;
        }
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
