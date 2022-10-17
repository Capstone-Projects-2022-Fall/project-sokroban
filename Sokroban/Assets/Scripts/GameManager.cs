using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Photon.Pun;


public class GameManager : MonoBehaviour
{
    public Button nextLevelBtn;
    public void Start()
    {
        nextLevelBtn.interactable = false;
    }
    public void Update()
    {
        if (checkWin())
        {
            nextLevelBtn.interactable = true;
            Debug.Log("you win");
        }
        else
        {
            nextLevelBtn.interactable = false;
        }
    }

    private static bool checkWin()
    {
        GameObject[] boxes = GameObject.FindGameObjectsWithTag("Box");
        foreach (var box in boxes)
        {
            if (Box.arrived)
            {
                return true;
            }
        }
        return false;
    }

    public void nextBtnClick()
    {
        nextLevelBtn.interactable = false;
        SceneManager.LoadScene("SPLevel");
    }
}
