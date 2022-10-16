using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Camera cam;

    public static float mapSize = 0.0f;
    public void Update()
    {
        cam.transform.position = new Vector3 (mapSize/2.5f, mapSize/2.0f, cam.transform.position.z); 
        cam.orthographicSize = mapSize/1.5f;
    }

    
}
