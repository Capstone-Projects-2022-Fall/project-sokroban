using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Photon.Pun;
/*
public struct Room 
{
    public string name;
    public int playersJoined;
}
*/
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
        //Room room;
        //Checks for empty room name
        if (string.IsNullOrEmpty(roomInput.text) || (string.IsNullOrEmpty(playersInput.text) && coopToggle.isOn))
        {
            errorText.text = "Text Fields Empty!";
            Debug.Log("Bad Room Name or No Players");
            return;
        }
        if (coopToggle.isOn)
        {
            //Checks if max players is set
            try
            {
                if (Int32.Parse(playersInput.text) > 5 || Int32.Parse(playersInput.text) < 2)
                {
                    errorText.text = "Max 5, Min 2 people per room!";
                    return;
                }
            }
            catch (Exception e)
            {
                errorText.text = e.Message;
                return;
            }
        }
        
        //Checks for empty game modes
        if (!coopToggle.isOn && !versusToggle.isOn)
        {
            errorText.text = "No Game Mode Selected";
            Debug.Log("No Game Mode Selected");
            return;
        }

        //Once all checks above are done do this

        PhotonNetwork.CreateRoom(roomInput.text);
        numOfPlayers = Int32.Parse(playersInput.text);      //Use this variable to scale the map in generator based on the max people to join.
        playersJoined = Int32.Parse(playersInput.text);     //Hold the max value. Subtract everytime someone joins the room.
        /*
        numOfPlayers = Int32.Parse(playersInput.text);      //Use this variable to scale the map in generator based on the max people to join.
        playersJoined = Int32.Parse(playersInput.text);     //Hold the max value. Subtract everytime someone joins the room.
        LevelTranslator.isCoop = true;
 */     Debug.Log("Room \"" + roomInput.text + "\" created");
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
        //if()      //Check if there are any spots available
        PhotonNetwork.JoinRoom(roomInput.text);
    }

    public override void OnJoinedRoom()
    {
        Debug.Log("Room \"" + roomInput.text + "\" joined");
        if (coopToggle.isOn)
        {
            LevelTranslator.isCoop = true;
            PhotonNetwork.LoadLevel("MPLevel"); //Needs coop config
        }
        if (versusToggle.isOn)
        {
            LevelTranslator.isVS = true;
            PhotonNetwork.LoadLevel("VSLevel");
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
            playersInput.interactable = true;
            versusToggle.isOn = false;
            firstToggleOn = true;
        }
        if (versusToggle.isOn)
        {
            playersInput.text = "2";
            playersInput.interactable = false;
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
