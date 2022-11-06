using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Photon.Pun;

public class GameManager : MonoBehaviour
{

    public Button nextLevelBtn;
    public Button undoBtn;
    public Button resetBtn;

    public Text loadingText;
    public Text wonText;
    //public static int numOfBoxes;
    int counter = 0;
    List<bool> boxesOnTarget = new List<bool>();
    public static int levelCounter = 1;

    public void Awake()
    {
        loadingText.text = "";
        wonText.text = "";

        undoBtn.interactable = false;
        resetBtn.interactable = false;
        nextLevelBtn.interactable = false; 
    }
    public void Update()
    {
        checkWin();
        if (LevelTranslator.crates == counter)
        {
            wonText.text = "YOU WON!";
            nextLevelBtn.interactable = true;
            TimerCount.LevelWon = true;
            undoBtn.interactable = false;
            resetBtn.interactable = false;

        }
        else
        {
            
            TimerCount.LevelWon = false;
            nextLevelBtn.interactable = false;
        }

        if(ScoreSystem.movesTaken > 0 && !(LevelTranslator.isChallenge || LevelTranslator.isCoop))
        {
            undoBtn.interactable = true;
            resetBtn.interactable = true;
        }
      
    }
    public void nextLevelBtnClick()
    {
        wonText.text = "";
        loadingText.text = "Loading...";
        levelCounter++;
        //levelCounter++;
        TimerCount.timer = 0.0f;
        nextLevelBtn.interactable = false;
        
        if(LevelTranslator.isCoop)
        {
            return;
        }
        else
        {
            //Time.timeScale = 1;
            SceneManager.LoadScene("SPLevel");
        }
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
