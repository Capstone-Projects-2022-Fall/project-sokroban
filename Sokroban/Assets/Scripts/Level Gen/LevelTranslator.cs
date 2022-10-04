using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelTranslator : MonoBehaviour
{
    Cell[,] map;
    public GameObject groundPrefab;
    public GameObject wallPrefab;
    public GameObject cratePrefab;
    public GameObject targetPrefab;
    public GameObject playerPrefab;
    //either we get the 2d array map straight from level
    public void setFinishedMap()
    {
        Level level = new Level();

        level.generate();
        level.postProcess();
        map = level.getMap().Clone() as Cell[,];//Should copy the 2d array generated in Level.cs
    }
    /*Or we do the export function inside of Program class, read the symbols into a 2d array
    public void readLevel()
    { }
    */
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
                        Instantiate(groundPrefab, position, Quaternion.identity);
                        break;
                    case Cell.Wall:
                        Instantiate(wallPrefab, position, Quaternion.identity);
                        break;
                    case Cell.Crate:
                        Instantiate(cratePrefab, position, Quaternion.identity);
                        break;
                    case Cell.Goal:
                        Instantiate(targetPrefab, position, Quaternion.identity);
                        break;
                    case Cell.Player:
                        Instantiate(playerPrefab, position, Quaternion.identity);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
