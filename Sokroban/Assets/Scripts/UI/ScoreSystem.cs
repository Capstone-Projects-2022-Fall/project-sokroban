using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreSystem : MonoBehaviour
{
    public float score = 0;
    public Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("Score", 10);
    }

     
  
    // Update is called once per frame
    void Update()
    {    // score = 100(Box On Target only once) - 5 (For Every Move) - 10 (If Time%100)
        scoreText.text = ("Score : " + PlayerPrefs.GetInt("Score").ToString());
    }
}
