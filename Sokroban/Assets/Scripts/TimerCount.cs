using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimerCount : MonoBehaviour
{
    float timer = 0;
    public TMP_Text timerText;

    // Update is called once per frame
    void Update()
    {
      timer += Time.deltaTime;
      timerText.text = timer.ToString();
    }
}
