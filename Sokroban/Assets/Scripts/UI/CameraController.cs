using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Camera cam;
    public static float mapSize = 0.0f;

    private float xMod, yMod, sizeMod;
    private void Start()
    {
        if (LevelTranslator.isVS)
        {
            xMod = 1.2f;
            yMod = 2.0f;
            sizeMod = 1.0f;
        }
        else
        {
            xMod = 2.5f;
            yMod = 2.0f;
            sizeMod = 1.5f;
        }
    }
    public void Update()
    {
        cam.transform.position = new Vector3 (mapSize/xMod, mapSize/yMod, cam.transform.position.z); 
        cam.orthographicSize = mapSize/sizeMod;
    }

    
}
