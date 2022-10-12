using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Photon.Pun;

public class GameManager : MonoBehaviour
{
    Player player;
    

    void Start() 
    {
        player = GetComponent<Player>();
    }


    public void Undo()
    {
        Debug.Log("Yoooo");
       
        //if(player.moves.Count > 0) //The stack has moves inside. In other words the player has done some moves
        //{
            Debug.Log("Here");
            if(player.moves.Peek().withBox) //In this case we are undoing the player and the box move
            {
                player.transform.position = new Vector3(player.moves.Peek().fromPos.x, 0);
                Debug.Log("Or Here");
                player.moves.Peek().boxMoved.transform.position = new Vector3(player.moves.Peek().boxPos.x, player.moves.Peek().boxPos.y, 0);
            }
            else    //But here only the player's move (there was not any box moved)
            {
                Debug.Log("Or eeeeeHere");
                player.transform.position = new Vector3(player.moves.Peek().fromPos.x, player.moves.Peek().fromPos.y, 0);
            }
            player.moves.Pop();
        //}
        
    }

}
