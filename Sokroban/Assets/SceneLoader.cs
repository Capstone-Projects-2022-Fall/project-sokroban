using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour {
    public void LoginButton(){

        SceneManager.LoadScene(1);

    }

    public void SignupButton(){

            SceneManager.LoadScene(2);
    }


}
