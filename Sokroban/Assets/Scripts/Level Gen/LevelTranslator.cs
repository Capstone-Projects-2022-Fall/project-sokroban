using System;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Photon.Pun;

public class LevelTranslator : MonoBehaviour
{
    Cell[,] map;

    private int levelSize;

    public GameObject groundPrefab;
    public GameObject wallPrefab;
    public GameObject cratePrefab;
    public GameObject targetPrefab;
    public GameObject playerPrefab;

    public static int crates, size;

    //types of modes
    public static bool isSandbox = false, isNormal = false, isChallenge = false, isCoop = false, isVS = false;
    Level level;
    private void Awake()
    {
        //if sandbox mode, use the number entered 
        if (isSandbox)
        {
            setTierSandbox();
            level = new Level(crates, size);
        }
        //else start from level 1
        else if (isNormal || isChallenge)
        {
            setTier();
            level = new Level(crates, size);
        }
        else if (isCoop)
        {
            //sets crates and size
            setTier();
            //level = new Level(crates, size, CreateAndJoinRooms.numOfPlayers);
            level = new Level(crates, size);
        }
        else if (isVS)
        {
            //sets crates and size
            setTier();
            level = new Level(crates, size);
        }
    }
    private void Start()
    {
        setFinishedMap();
        translateToPrefabs(0);
        if (isVS)
        {
            translateToPrefabs(size+1);
        }
    }

    public void setTierSandbox()
    {
        switch (crates)
        {
            //Tier 1
            case 1:
                size = 8;
                break;
            //Tier 2
            case 2:
                size = 11;
                break;
            //Tier 3
            case 3:
                size = 11;
                break;
            //Tier 4
            case 4:
                size = 12;
                break;
            //Tier 5
            case 5:
                size = 15;
                break;
            //Tier 6
            case 6:
                size = 15;
                break;
            //Tier 7
            case 7:
                size = 15;
                break;
            //Tier 8
            case 8:
                size = 15;
                break;
            //Tier 9
            case 9:
                size = 18;
                break;
            //Tier 10
            case 10:
                size = 18;
                break;
        }
    }

    public void setTier()
    {
        if(isCoop)
        {
            if(CreateAndJoinRooms.isMaster)
            {
                /*
                switch (CreateAndJoinRooms.numOfPlayers)
                {
                    //2 Players
                    case 2:
                        crates = 2;
                        size = 11;
                        break;
                    //3 Players
                    case 3:
                        crates = 3;
                        size = 11;
                        break;
                    //4 Players
                    case 4:
                        crates = 4;
                        size = 12;
                        break;
                    //5 Players
                    case 5:
                        crates = 5;
                        size = 15;
                        break;
                    //6 Players
                    case 6:
                        crates = 6;
                        size = 15;
                        break;
                    //7 Players
                    case 7:
                        crates = 7;
                        size = 15;
                        break;
                    //8 Players
                    case 8:
                        crates = 8;
                        size = 15;
                        break;
                    //9 Players
                    case 9:
                        crates = 9;
                        size = 18;
                        break;
                    //10 Players
                    case 10:
                        crates = 10;
                        size = 18;
                        break;
                }
                */
                crates = 10;
                size = 18;
            }
            else
            {
                crates = 9;
                size = 18;
            }
        }
        else if(isVS)
        {
            crates = 6;
            size = 15;
        }
        else
        {
            switch (GameManager.levelCounter)
            {
                //Tier 1
                case 1:
                    crates = 1;
                    size = 8;
                    break;
                //Tier 2
                case 4:
                    crates = 2;
                    size = 11;
                    break;
                //Tier 3
                case 7:
                    crates = 3;
                    size = 11;
                    break;
                //Tier 4
                case 10:
                    crates = 4;
                    size = 12;
                    break;
                //Tier 5
                case 13:
                    crates = 5;
                    size = 15;
                    break;
                //Tier 6
                case 16:
                    crates = 6;
                    size = 15;
                    break;
                //Tier 7
                case 19:
                    crates = 7;
                    size = 15;
                    break;
                //Tier 8
                case 22:
                    crates = 8;
                    size = 15;
                    break;
                //Tier 9
                case 25:
                    crates = 9;
                    size = 18;
                    break;
                //Tier 10
                case 28:
                    crates = 10;
                    size = 18;
                    break;
            }
        }
    }


    //either we get the 2d array map straight from level
    public void setFinishedMap()
    {
        do
        {
            Debug.Log("Master is: "+ CreateAndJoinRooms.isMaster);
            level.generate();
            level.postProcess();
            map = level.getMap().Clone() as Cell[,];//Should copy the 2d array generated in Level.cs
        } while (level.hasErrors());
        exportMap(level);
        //Sets size for camera
        CameraController.mapSize = (float)size;
    }

    public int getLevelSize()
    {
        return levelSize;
    }

    // And then translate them here
    public void translateToPrefabs(int offeset)
    {
        //x and y should correspond to the 2d array map
        for (int x = 0; x < map.GetLength(0); x++)
        {
            for (int y = 0; y < map.GetLength(1); y++)
            {
                Vector3 position = new Vector3(x + offeset, y, 0);
                switch (map[x, y])
                {
                    //Each spawn should consider the size of the previous object,
                    //create an offest value equal to the size of each object to make sure
                    //they dont spawn on top of each other
                    case Cell.Floor:
                       //groundCount++;
                       if(isCoop || isVS)
                        {
                            if(CreateAndJoinRooms.isMaster){
                                Debug.Log("Master is: "+ CreateAndJoinRooms.isMaster);
                                PhotonNetwork.Instantiate(groundPrefab.name, position, Quaternion.identity);
                            }
                        }
                        else 
                        {
                            Instantiate(groundPrefab, position, Quaternion.identity);
                        }
                        break;
                    case Cell.Wall:
                        //wallCount++;
                        if(isCoop || isVS)
                        {
                            if(CreateAndJoinRooms.isMaster){
                                PhotonNetwork.Instantiate(wallPrefab.name, position, Quaternion.identity);
                            }
                        }
                        else
                        {
                            Instantiate(wallPrefab, position, Quaternion.identity);
                        }
                        break;
                    case Cell.Crate:
                        //groundCount++;
                        //crateCount++;
                        if(isCoop || isVS)
                        {
                            if(CreateAndJoinRooms.isMaster){
                                PhotonNetwork.Instantiate(groundPrefab.name, position, Quaternion.identity);
                                PhotonNetwork.Instantiate(cratePrefab.name, position, Quaternion.identity);
                            }
                        }
                        else
                        {
                            Instantiate(groundPrefab, position, Quaternion.identity);
                            Instantiate(cratePrefab, position, Quaternion.identity);
                        }
                        break;
                    case Cell.Goal:
                        //groundCount++;
                        //targetCount++;
                        if(isCoop || isVS)
                        {
                            if(CreateAndJoinRooms.isMaster){
                                PhotonNetwork.Instantiate(groundPrefab.name, position, Quaternion.identity);
                                PhotonNetwork.Instantiate(targetPrefab.name, position, Quaternion.identity);
                            }
                        }
                        else
                        {
                            Instantiate(groundPrefab, position, Quaternion.identity);
                            Instantiate(targetPrefab, position, Quaternion.identity);
                        }
                        break;
                    case Cell.Player:
                        //groundCount++;
                        //playerCount++;
                        if(isCoop)
                        {
                            
                                PhotonNetwork.Instantiate(groundPrefab.name, position, Quaternion.identity);
                                PhotonNetwork.Instantiate(playerPrefab.name, position, Quaternion.identity);
                            
                        }
                        else if(isVS)
                        {
                            if(CreateAndJoinRooms.isMaster)
                            {
                                PhotonNetwork.Instantiate(groundPrefab.name, position, Quaternion.identity);
                                PhotonNetwork.Instantiate(playerPrefab.name, position, Quaternion.identity);
                            }
                        }
                        else 
                        {
                            Instantiate(groundPrefab, position, Quaternion.identity);
                            Instantiate(playerPrefab, position, Quaternion.identity);
                        }
                        
                        break;
                    default:
                        if(isCoop || isVS)
                        {
                            if(CreateAndJoinRooms.isMaster){
                                PhotonNetwork.Instantiate(wallPrefab.name, position, Quaternion.identity);
                            }
                        }
                        else
                        {
                            Instantiate(wallPrefab, position, Quaternion.identity);
                        }
                        break;
                }
            }
        }
    }

    public void exportMap(Level level)
    {
        string path = "./Levels/GeneratedLevel.txt";
        try
        {
            // Create the file, or overwrite if the file exists.
            using (FileStream fs = File.Create(path))
            {
                byte[] info = new UTF8Encoding(true).GetBytes(level.ToString());
                // Add some information to the file.
                fs.Write(info, 0, info.Length);
            }

            Debug.Log("Level GeneratedLevel exported to " + path);
        }
        catch (Exception ex)
        {
            Debug.Log(ex.ToString());
        }
    }

    public IEnumerator resetMap()
    {
        AsyncOperation asyncUnload = SceneManager.UnloadSceneAsync("SPLevel");
        while (!asyncUnload.isDone)
        {
            yield return null;
            Debug.Log("Loading scene...");
        }
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("SPLevel", LoadSceneMode.Additive);
        while (!asyncLoad.isDone)
        {
            yield return null;
            Debug.Log("Loading scene...");
        }
        SceneManager.SetActiveScene(SceneManager.GetSceneByName("SPLevel"));
        translateToPrefabs(0);
        //SceneManager.LoadScene("Temp");
    }

}