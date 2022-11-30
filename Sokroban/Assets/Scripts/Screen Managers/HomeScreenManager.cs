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
            StartCoroutine(FetchData());
        }
    }

    public void OnClickGuest()
    {
        SceneManager.LoadScene("Main Menu");
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
            StartCoroutine(PostData(usernameInput.text, passwordInput.text));
            SceneManager.LoadScene("Main Menu");
            Debug.Log("Entered Main Menu");
        }
    }

    IEnumerator PostData(string usr, string pass)
    {

        string uri = "http://sokroban.azurewebsites.net/Sokroban/SignUp?Username=" + usr + "&Password=" + pass;
               
        WWWForm form = new WWWForm();
        form.AddField("Username", "");
        form.AddField("Password", "");
        using (UnityWebRequest request = UnityWebRequest.Post(uri, form))
        {
            yield return request.SendWebRequest();

        }
    }

IEnumerator FetchData()
    {

        string uri = "https://sokroban.azurewebsites.net/Sokroban/Login?usr=" + usernameInput.text;
        using (UnityWebRequest request = UnityWebRequest.Get(uri))
        {
            yield return request.SendWebRequest();



            //PlayerInfo playerInfo = new PlayerInfo();
            //playerInfo = JsonUtility.FromJson<PlayerInfo>(request.downloadHandler.text);
            //PlayerInfo playerInfo = JsonUtility.FromJson<PlayerInfo>(request.downloadHandler.text);
            //playerInfo = JsonUtility.FromJson<PlayerInfo>(JsonUtility.ToJson(data));

            //string UserCheck = playerInfo.Username;
            ////string PasswordCheck = "MileDemo";            
            //string PasswordCheck = ;

            string data = request.downloadHandler.text;
            string DP = data.Substring((28 + usernameInput.text.Length));
            DP = DP.Substring(0, DP.Length - 3);

            string PassInput = passwordInput.text;

            if (PassInput.Equals(DP))
            {
                SceneManager.LoadScene("Main Menu");
                Debug.Log("Entered Main Menu");
            }
            else
            {
                errorText.text = "Incorrect Username/Password, Please try again";
            }
        }
    }

}
