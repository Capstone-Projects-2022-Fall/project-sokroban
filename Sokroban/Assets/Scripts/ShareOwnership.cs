using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class ShareOwnership : MonoBehaviourPun
{

    private void OnMouseDown() 
    {
        if(LevelTranslator.isCoop || LevelTranslator.isVS)
        {
            base.photonView.RequestOwnership();
        }
    }
}
