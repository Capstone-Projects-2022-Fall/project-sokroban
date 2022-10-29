using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Photon.Pun;

public class GameManager : MonoBehaviour
{

    public Button nextLevelBtn;
    //public static int numOfBoxes;
    int counter = 0;
    List<bool> boxesOnTarget = new List<bool>();
    public static int levelCounter = 1;

    public void Awake()
    {
        nextLevelBtn.interactable = false; 
    }
    public void Update()
    {
        checkWin();
        if (LevelTranslator.crates == counter)
        {
            nextLevelBtn.interactable = true;
        }
        else
        {
            nextLevelBtn.interactable = false;
        }
      
    }
    public void nextLevelBtnClick()
    {
        levelCounter++;
        //levelCounter++;
        TimerCount.timer = 0.0f;
        nextLevelBtn.interactable = false;
        SceneManager.LoadScene("SPLevel");
    }

    void checkWin()
    {
        boxesOnTarget.Clear();
        counter = 0;
        GameObject[] boxes = GameObject.FindGameObjectsWithTag("Box");
        GameObject[] targets = GameObject.FindGameObjectsWithTag("Target");
        foreach (var target in targets) 
        {
            foreach (var box in boxes) 
            {
                
                if (box.transform.position.x == target.transform.position.x && box.transform.position.y == target.transform.position.y) 
                {
                    boxesOnTarget.Add(true);
                    counter++;
                }
                else
                {
                    boxesOnTarget.Add(false);
                }
                
            }
        }      
    }
}
