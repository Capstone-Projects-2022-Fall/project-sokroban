using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Photon.Pun;

public class CreateAndJoinRooms : MonoBehaviourPunCallbacks
{
    public InputField roomInput;
    public InputField playersInput;
    
    private int playersJoined;

    public Text errorText;

    public Toggle coopToggle;
    public Toggle versusToggle;

    public static int numOfPlayers;

    bool firstToggleOn = false;
    public void CreateRoom()
    {
        //Checks for empty room name
        if (string.IsNullOrEmpty(roomInput.text)|| string.IsNullOrEmpty(playersInput.text))
        {
            errorText.text = "Text Fields Empty!";
            Debug.Log("Bad Room Name or No Players");
            return;
        }
        //Checks for empty game modes
        if (!coopToggle.isOn && !versusToggle.isOn)
        {
            errorText.text = "No Game Mode Selected";
            Debug.Log("No Game Mode Selected");
            return;
        }
        PhotonNetwork.CreateRoom(roomInput.text);
        numOfPlayers = Int32.Parse(playersInput.text);      //Use this variable to scale the map in generator based on the max people to join.
        playersJoined = Int32.Parse(playersInput.text);     //Hold the max value. Subtract everytime someone joins the room.
    
        Debug.Log("Room \"" + roomInput.text + "\" created");
    }

    public void JoinRoom()
    {
        //Checks for empty room name
        if (string.IsNullOrEmpty(roomInput.text))
        {
            errorText.text = "Room Name Empty";
            Debug.Log("Bad Room Name");
            return;
        }
        PhotonNetwork.JoinRoom(roomInput.text);
    }

    public override void OnJoinedRoom()
    {
        Debug.Log("Room \"" + roomInput.text + "\" joined");
        PhotonNetwork.LoadLevel("MPLevel"); //Needs coop config
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
