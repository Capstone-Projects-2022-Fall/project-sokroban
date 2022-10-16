using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeSound : MonoBehaviour
{

    private Sprite soundOnImage;
    public Sprite soundOffImage;
    public Button button;
    private bool isOn = true;

    public AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        soundOnImage = button.image.sprite;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onMuteClick()
    {
        if (isOn)
        {
            button.image.sprite = soundOffImage;
            isOn = false;
            audioSource.mute = true;
        }
        else
        {
            button.image.sprite = soundOnImage;
            isOn = true;
            audioSource.mute = false;
            
        }
    }

}
