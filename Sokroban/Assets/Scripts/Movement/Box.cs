using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
   public bool Move(Vector2 direction) {        //Avoid moving diagonally

        if (BoxBlocked(transform.position, direction)) {    //if box is blocked then dont move it
            return false;
        }

        else {
            transform.Translate(direction);     //if not then move.
            //TransformForCross();
            return true;
        }
    }

    private bool BoxBlocked(Vector3 position, Vector2 direction) 
    {          //Same as player blocked method.

        Vector2 newPos = new Vector2(position.x, position.y) + direction;       //Check to see if there is a wall where we trying to move.
        GameObject[] walls = GameObject.FindGameObjectsWithTag("Wall");
        foreach (var wall in walls) 
        {
            if (wall.transform.position.x == newPos.x && wall.transform.position.y == newPos.y) {
                
                return true;                                                            //If there is a wall then box is blocked.
            }
        }
        GameObject[] boxes = GameObject.FindGameObjectsWithTag("Box");                      //Check for boxes now
        foreach (var box in boxes) 
        {
            if (box.transform.position.x == newPos.x && box.transform.position.y == newPos.y) //If there is another box
            {
                    return true;                                                                    //Then we are blocked again.
            }
        }
        return false;
    }


}