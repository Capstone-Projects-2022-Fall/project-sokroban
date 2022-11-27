using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using System;

public class SendSize : MonoBehaviourPun
{
    
    
    string x = "Null";
    string sizeOf = "Null", cratesOf = "Null";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(PhotonNetwork.IsMasterClient)
        {
            this.photonView.RPC("SetSize", RpcTarget.All, "5", "1");
        }
        else
        {
            this.photonView.RPC("SetSize", RpcTarget.All, "1", "2");
        }

        
    }

    [PunRPC]
    void ChatMessage(string a, string b)
    {
        Debug.Log(string.Format("ChatMessage {0} {1}", a, b));
    }

    [PunRPC]
    void SetSize(string x, string y)
    {
        sizeOf = x;
        cratesOf = y;
        Debug.Log("Size is " + Int32.Parse(sizeOf) + " Crate is " + Int32.Parse(cratesOf));
    }

    
    
}
