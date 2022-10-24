using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelCount : MonoBehaviour
{
    public Text levelText;

    void Update()
    {
        levelText.text = ("Level: " + GameManager.levelCounter);
    }
}
