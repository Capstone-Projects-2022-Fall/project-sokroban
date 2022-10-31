using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public struct Moves
{
    public Vector3 fromPos;
    public Vector3 toPos;
    public Box boxMoved;
    public Vector3 boxPos;
    public bool withBox;
    public Player user;
}

public struct BlockedBy
{
    public bool isBlocked;
    public bool isBlockedByBox;
}


public class Player : MonoBehaviour
{ 

    PhotonView view;

    
    static Stack<Moves>moves = new Stack<Moves>();
    static Moves move;
 
    

    void Start() 
    {
        //anim = GetComponent<Animator>();
        view = GetComponent<PhotonView>();
        
    }

    
    public bool Move(Vector2 direction) 
    {
        
        if(Mathf.Abs(direction.x) < 0.5) //Does not allow diagonal moves
        {
            direction.x = 0;
        }
        else
        {
            direction.y = 0;
        }
        direction.Normalize(); //1 movement at a time. x=1 or y=1

        if (Blocked(transform.position, direction).isBlockedByBox)  //Is the player blocked by a box?
        {
            if (Blocked(transform.position, direction).isBlocked)   //Is the player blocked in general? (ex 2 boxes or box on wall)
            {
                        
                return false;
            }
            else                                                //Can move with the box.
            {   
                
                move.fromPos = transform.position;
                move.toPos = new Vector3(transform.position.x + direction.x, transform.position.y + direction.y, 0);
                move.withBox = true;        //We are moving with the box
                move.user = this;
                moves.Push(move);   //Push this move into the stack
                transform.Translate(direction);
                ScoreSystem.movesTaken++;
            }
        }
        else
        {
            if(Blocked(transform.position, direction).isBlocked)
            {
                
                return false;
            }
            else
            {
                
                move.fromPos = transform.position;
                move.toPos = new Vector3(transform.position.x + direction.x, transform.position.y + direction.y, 0);
                move.withBox = false;   //We are moving without the box!
                move.user = this;
                moves.Push(move); //Push this move into the stack
                transform.Translate(direction);
                ScoreSystem.movesTaken++;
            }
        }
        return true;
    }
    
    BlockedBy Blocked(Vector3 position, Vector2 direction) 
    {
        Vector2 newPos = new Vector2(position.x, position.y) + direction; //Position we want to move to
        BlockedBy blockedby;
        GameObject[] Walls = GameObject.FindGameObjectsWithTag("Wall");        //We need to tag walls and boxes with corrcect tag.

        foreach (var wall in Walls)
        {   
            if((wall.transform.position.x == newPos.x) && (wall.transform.position.y == newPos.y)) //Is there a wall in the position we are trying to move to?
            {
                blockedby.isBlocked = true;
                blockedby.isBlockedByBox = false;
                return blockedby;            //Then player is blocked
            }
        }
        Box bx;
        GameObject[] boxes = GameObject.FindGameObjectsWithTag("Box");     //Now check for boxes
        foreach (var box in boxes)
        {
            if((box.transform.position.x == newPos.x) && (box.transform.position.y == newPos.y))   //Is there a box?
            {
                bx = box.GetComponent<Box>();
                if(bx)
                {
                    
                    move.boxMoved = bx;
                    move.boxPos = bx.transform.position;
                }

                if (bx && bx.Move(direction))           //can the box move if we push it?
                {
                    
                    blockedby.isBlocked = false;
                    blockedby.isBlockedByBox = true;
                    
                    return blockedby;                       //If so then return false because we are not blocked
                }
                else                                    //If the box cannot move then we are blocked (return tue)
                {
                    blockedby.isBlocked = true;
                    blockedby.isBlockedByBox = true;
                    return blockedby;
                }
            }
        }
        blockedby.isBlocked = false;
        blockedby.isBlockedByBox = false;
        return blockedby;                   //If none of them works then we are not blocked.

    }

    private bool m_readyForInput;
    
    void Update() 
    {
        if (MainMenuManager.isMultiplayer)
        {
            if (view.IsMine)
            {
                Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

                moveInput.Normalize();

                if (moveInput.sqrMagnitude > 0.5) //Button pressed or held
                {

                    if (m_readyForInput)            //Moves only when pressing the key again.
                    {
                        m_readyForInput = false;
                        this.Move(moveInput);
                    }
                }
                else
                {
                    m_readyForInput = true;
                }
            }
        }
        else
        {
            Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

            moveInput.Normalize();

            if (moveInput.sqrMagnitude > 0.5) //Button pressed or held
            {

                if (m_readyForInput)            //Moves only when pressing the key again.
                {
                    m_readyForInput = false;
                    this.Move(moveInput);
                }
            }
            else
            {
                m_readyForInput = true;
            }
        }
/*
        if(Input.GetKeyDown("space")) 
        {
            if(moves.Count > 0) //The stack has moves inside. In other words the player has done some moves
            {
                Debug.Log("here");
                if(moves.Peek().withBox) //In this case we are undoing the player and the box move
                {
                    Debug.Log("Until here");
                    this.transform.position = new Vector3(moves.Peek().fromPos.x, moves.Peek().fromPos.y, 0);
                    moves.Peek().boxMoved.transform.position = new Vector3(moves.Peek().boxPos.x, moves.Peek().boxPos.y, 0);
                }
                else    //But here only the player's move (there was not any box moved)
                {
                    this.transform.position = new Vector3(moves.Peek().fromPos.x, moves.Peek().fromPos.y, 0);
                
                }
                moves.Pop();
            }
        }
    */
    }

    public void Undo()
    { 
        if(moves.Count > 0) //The stack has moves inside. In other words the player has done some moves
        {
            if(moves.Peek().withBox) //In this case we are undoing the player and the box move
            {
                
                moves.Peek().user.transform.position = new Vector3(moves.Peek().fromPos.x, moves.Peek().fromPos.y);
                
                moves.Peek().boxMoved.transform.position = new Vector3(moves.Peek().boxPos.x, moves.Peek().boxPos.y, moves.Peek().fromPos.z);
            }
            else    //But here only the player's move (there was not any box moved)
            {
                moves.Peek().user.transform.position = new Vector3(moves.Peek().fromPos.x, moves.Peek().fromPos.y, moves.Peek().fromPos.z);
               
            }
            moves.Pop();
        }
        
    }   

    public void Reset() 
    {
        int i = moves.Count;
        while(i >= 0)
        {
            Undo();
            i--;
        }
    }
        
    
    
}


