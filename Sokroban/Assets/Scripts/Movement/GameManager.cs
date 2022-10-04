using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    
    private bool m_readyForInput;
    public Player m_Player;


    void Update() 
    {
        Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        
        moveInput.Normalize();

        if (moveInput.sqrMagnitude > 0.5) //Button pressed or held
        {     

            if (m_readyForInput)            //Moves only when pressing the key again.
            {
                m_readyForInput = false;
                m_Player.Move(moveInput);
            }
        }
        else 
        {
            m_readyForInput = true;
        }
    }
}
