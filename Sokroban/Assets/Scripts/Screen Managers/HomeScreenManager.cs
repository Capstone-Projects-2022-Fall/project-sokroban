using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Networking;
using System.Net.Http;



public class HomeScreenManager : MonoBehaviour
{
    public string URLg;
    public string URLp;
    public InputField usernameInput;
    public InputField passwordInput;
    public Text errorText;
    public string password;



    
    public IEnumerator FetchData(string usr)
    {

        string uri = "https://sokroban.azurewebsites.net/Sokroban/Check?usr=" + usr;
        using (UnityWebRequest request = UnityWebRequest.Get(uri))
        {
            yield return request.SendWebRequest();

        
        }
    }

    public void OnClickLogin()
    {
        if (string.IsNullOrEmpty(usernameInput.text) || string.IsNullOrEmpty(passwordInput.text))
        {
            errorText.text = "Input Username and Password!";

            Debug.Log("Bad credentials");
            return;
        }
        else
        {
            //FetchData(usernameInput.text);
            SceneManager.LoadScene("Main Menu");
            Debug.Log("Entered Main Menu");
        }
    }

    public void OnClickSignUp()
    {
        if (string.IsNullOrEmpty(usernameInput.text) || string.IsNullOrEmpty(passwordInput.text))
        {
            errorText.text = "Input Username and Password!";
            Debug.Log("Bad credentials");
            return;
        } 
        else 
        {
            StartCoroutine(PostData(usernameInput.text,passwordInput.text));
            SceneManager.LoadScene("Main Menu"); 
            Debug.Log("Entered Main Menu");
        }
    }

    IEnumerator PostData(string usr, string pass)
    {
     
        string uri = "https://sokroban.azurewebsites.net/Sokroban/SokLogin?Username=" + usr + "&Password=" + pass;
        WWWForm form = new WWWForm();
        form.AddField("Username", "");
        form.AddField("Password", "");
        using (UnityWebRequest request = UnityWebRequest.Post(uri, form))
        {
            yield return request.SendWebRequest();
        }
    }


}