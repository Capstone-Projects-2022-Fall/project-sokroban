using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class ShareOwnership : MonoBehaviourPun
{
    
    private void OnMouseDown() 
    {
        
        base.photonView.RequestOwnership();
    }
}
