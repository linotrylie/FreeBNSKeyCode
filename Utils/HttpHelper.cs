using FreeBNS.Model;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeBNS.Utils
{
    class HttpHelper
    {
        private static string url = "http://freebns.local.com/";
        private static string userLoginUrl = "newuser-login.htm";
        private static string host = "freebns.local.com";
        public static User PostLogin(string username,string password)
        {
            var options = new RestClientOptions(url)
            {
                MaxTimeout = -1
            };
            var client = new RestClient(options);
            var request = new RestRequest(userLoginUrl, Method.Post);
            request.AddHeader("Accept", "*/*");
            request.AddHeader("Host", host);
            request.AddHeader("Connection", "keep-alive");
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddParameter("username", username);
            request.AddParameter("password", password);
            var response = client.Execute(request);
            ResponseBody obj = new ResponseBody();
            obj.Data = new User();
            obj = JsonConvert.DeserializeObject<ResponseBody>(response.Content);
            if(obj.Code == "1")
            {
                return null;
            }
            User user = JsonConvert.DeserializeObject<User>(obj.Data.ToString());
            return user;
        }
    }
}
