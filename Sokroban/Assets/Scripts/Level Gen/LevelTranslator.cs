using System;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelTranslator : MonoBehaviour
{
    Cell[,] map;

    private int levelSize;

    public GameObject groundPrefab;
    public GameObject wallPrefab;
    public GameObject cratePrefab;
    public GameObject targetPrefab;
    public GameObject playerPrefab;


    private void Start()
    {
        setFinishedMap();
        translateToPrefabs();
    }

    //either we get the 2d array map straight from level
    public void setFinishedMap()
    {
        SPLobbyManager lobbyManager = new SPLobbyManager();
        Level level = new Level(4);

        do
        {
            level.generate();
            level.postProcess();
            map = level.getMap().Clone() as Cell[,];//Should copy the 2d array generated in Level.cs
        } while (level.hasErrors());
        exportMap(level);
        //Sets size for camera
        levelSize = level.getWidth();
    }

    public int getLevelSize()
    {
        return levelSize;
    }

    // And then translate them here
    public void translateToPrefabs()
    {
        //x and y should correspond to the 2d array map
        for (int x = 0; x < map.GetLength(0); x++)
        {
            for (int y = 0; y < map.GetLength(1); y++)
            {
                Vector3 position = new Vector3(x, y, 0);
                switch (map[x, y])
                {
                    //Each spawn should consider the size of the previous object,
                    //create an offest value equal to the size of each object to make sure
                    //they dont spawn on top of each other
                    case Cell.Floor:
                       //groundCount++;
                        Instantiate(groundPrefab, position, Quaternion.identity);
                        break;
                    case Cell.Wall:
                        //wallCount++;
                        Instantiate(wallPrefab, position, Quaternion.identity);
                        break;
                    case Cell.Crate:
                        //groundCount++;
                        //crateCount++;
                        Instantiate(groundPrefab, position, Quaternion.identity);
                        Instantiate(cratePrefab, position, Quaternion.identity);
                        break;
                    case Cell.Goal:
                        //groundCount++;
                        //targetCount++;
                        Instantiate(groundPrefab, position, Quaternion.identity);
                        Instantiate(targetPrefab, position, Quaternion.identity);
                        break;
                    case Cell.Player:
                        //groundCount++;
                        //playerCount++;
                        Instantiate(groundPrefab, position, Quaternion.identity);
                        Instantiate(playerPrefab, position, Quaternion.identity);
                        break;
                    default:
                        Instantiate(groundPrefab, position, Quaternion.identity);
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
        translateToPrefabs();
        //SceneManager.LoadScene("Temp");
    }

}
