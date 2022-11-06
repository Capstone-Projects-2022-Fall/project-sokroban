using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerCount : MonoBehaviour
{
    public static float timer = 0.0f;
    public static bool LevelWon;
    public Text timerText;

    // Update is called once per frame
    void Update()
    {
      timer += Time.deltaTime;
      timerText.text = ("Time: " + Math.Round(timer).ToString());
      if(LevelWon)
      {
        Time.timeScale = 0;
      }
      else
      {
        Time.timeScale = 1;
      }

    }
}
