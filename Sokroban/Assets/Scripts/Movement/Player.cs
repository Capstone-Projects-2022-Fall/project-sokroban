using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    
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


            if (Blocked(transform.position, direction)) //If player is blocked then dont move
            {
                return false;
            }
            else
            {
                transform.Translate(direction);     //otherwise move
                return true;
            }
    }

    bool Blocked(Vector3 position, Vector2 direction) 
    {
            Vector2 newPos = new Vector2(position.x, position.y) + direction; //Position we want to move to
            
            GameObject[] Walls = GameObject.FindGameObjectsWithTag("Wall");        //We need to tage walls and boxes with corrcect tag.
            foreach (var wall in Walls)
            {   
                if((wall.transform.position.x == newPos.x) && (wall.transform.position.y == newPos.y)) //Is there a wall in the position we are trying to move to?
                {
                    return true;            //Then player is blocked
                }
            }
            GameObject[] boxes = GameObject.FindGameObjectsWithTag("Box");     //Now check for boxes
            foreach (var box in boxes)
            {
                if((box.transform.position.x == newPos.x) && (box.transform.position.y == newPos.y))   //Is there a box?
                {
                    Box bx = box.GetComponent<Box>();
                    if (bx && bx.Move(direction))           //can the box move if we push it?
                    {
                        return false;                       //If so then return false because we are not blocked
                    }
                    else                                    //If the box cannot move then we are blocked (return tue)
                    {
                        return true;
                    }
                }
            }
            return false;                   //If none of them works then we are not blocked.

    }

    private bool m_readyForInput;
    
    void Update() 
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


