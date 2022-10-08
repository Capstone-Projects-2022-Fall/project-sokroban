using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Camera cam;
    public void UpdateSize(int size)
    {
        cam.orthographicSize = 6;
    }

    
}
