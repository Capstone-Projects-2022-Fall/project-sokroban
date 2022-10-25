using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;
// Need one for connected model... gotta figure out how to do that
using Flurl.Http;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApiTalk : MonoBehaviour
{
    // Start is called before the first frame update
    public SokModel RestService(Entry Username, Entry Password)
    {
        using (var client = new FlurlClient("https://sokroban.azurewebsites.net"))
        {
            try
            {
                System.Net.ServicePointManager.ServerCertificateValidationCallback += (sender, certificate, chain, sslPolicy) => { return true; };
                var result = client.Request("Sokroban/SokLogin")
                    .SetQueryParam("Username", Username.Text)
                    .SetQueryParam("Password", Password.Text)

                return result;
            }
            catch (FlurlHttpException fe)
            {
                var error = fe;
                return null;
            }
            catch (Exception e)
            {
                var v = e;
                return null;
            }
        }
    }

} 
}
