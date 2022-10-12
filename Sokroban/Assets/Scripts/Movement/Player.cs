using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
//using UniRx;

public struct Moves
{
    public Vector2 fromPos;
    public Vector2 toPos;
    public Box boxMoved;
    public Vector2 boxPos;
    public bool withBox;
}

public struct BlockedBy
{
    public bool isBlocked;
    public bool isBlockedByBox;
}

public class Player : MonoBehaviour
{
    PhotonView view;
    //Box bx;
    
    public Stack<Moves> moves = new Stack<Moves>();
    public Moves move;

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
                Debug.Log("Is Blocked");        
                return false;
            }
            else                                                //Can move with the box.
            {   
                Debug.Log("Moves with box");
                move.fromPos = transform.position;
                move.toPos = new Vector2(direction.x, direction.y);
                move.withBox = true;        //We are moving with the box
                moves.Push(move);   //Push this move into the stack

                transform.Translate(direction);     
            }
        }
        else
        {
            if(Blocked(transform.position, direction).isBlocked)
            {
                Debug.Log("Blocked by wall");
                return false;
            }
            else
            {
                Debug.Log("Is just moving without box");
                move.fromPos = transform.position;
                move.toPos = new Vector2(direction.x, direction.y);
                move.withBox = false;   //We are moving without the box!
                moves.Push(move); //Push this move into the stack
                transform.Translate(direction);
            }
        }
        return true;
    }

    BlockedBy Blocked(Vector2 position, Vector2 direction) 
    {
        Vector2 newPos = new Vector2(position.x, position.y) + direction; //Position we want to move to
        BlockedBy blocked;
        GameObject[] Walls = GameObject.FindGameObjectsWithTag("Wall");        //We need to tag walls and boxes with corrcect tag.

        foreach (var wall in Walls)
        {   
            if((wall.transform.position.x == newPos.x) && (wall.transform.position.y == newPos.y)) //Is there a wall in the position we are trying to move to?
            {
                blocked.isBlocked = true;
                blocked.isBlockedByBox = false;
                return blocked;            //Then player is blocked
            }
        }
        GameObject[] boxes = GameObject.FindGameObjectsWithTag("Box");     //Now check for boxes
        foreach (var box in boxes)
        {
            if((box.transform.position.x == newPos.x) && (box.transform.position.y == newPos.y))   //Is there a box?
            {
                Box bx = box.GetComponent<Box>();
                if(bx)
                {
                    move.withBox = bx;
                    move.boxPos = bx.transform.position;
                }

                if (bx && bx.Move(direction))           //can the box move if we push it?
                {
                    blocked.isBlocked = false;
                    blocked.isBlockedByBox = true;
                    return blocked;                       //If so then return false because we are not blocked
                }
                else                                    //If the box cannot move then we are blocked (return tue)
                {
                    blocked.isBlocked = true;
                    blocked.isBlockedByBox = true;
                    return blocked;
                }
            }
        }
        blocked.isBlocked = false;
        blocked.isBlockedByBox = false;
        return blocked;                   //If none of them works then we are not blocked.

    }

    private bool m_readyForInput;
    
    void Update() 
    {
      //  if (view.IsMine)
      //  {
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
      //  }
    }

    public void Undo()
    {
        //player = 
        //if(this.moves.Count > 0) //The stack has moves inside. In other words the player has done some moves
        //{
            Debug.Log("here");
            if(this.moves.Peek().withBox) //In this case we are undoing the player and the box move
            {
                this.transform.position = new Vector2(this.moves.Peek().fromPos.x, this.moves.Peek().fromPos.y);
                this.moves.Peek().boxMoved.transform.position = new Vector2(this.moves.Peek().boxPos.x, this.moves.Peek().boxPos.y);
            }
            else    //But here only the player's move (there was not any box moved)
            {
               this.transform.position = new Vector2(this.moves.Peek().fromPos.x, this.moves.Peek().fromPos.y);
            }
            this.moves.Pop();
        //}
    }
    
}


