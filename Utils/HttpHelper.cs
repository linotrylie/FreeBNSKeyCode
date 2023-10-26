using FreeBNS.Model;
using Newtonsoft.Json;
using RestSharp;
using System.Collections.Generic;

namespace FreeBNS.Utils
{
    class HttpHelper
    {
        private static string url = "https://free-bns.com/";
        private static string userLoginUrl = "newuser-login.htm";
        private static string saveKadaoDataUrl = "newuser-save_kadao_data.htm";
        private static string getKadaoBiLiUrl = "newuser-get_kadao_bili.htm";
        private static string chongZhiKadaoTimeUrl = "newuser-chongzhi_kadao_time.htm";
        private static string delMyKadaoDataUrl = "newuser-del_my_kadao_data.htm";
        private static string getMyKadaoDataListUrlFormat = "/newuser-get_my_kadao_data.htm?username={0}&page_size={1}&page={2}";
        private static string host = "free-bns.com";
        public static User PostLogin(string username, string password)
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
            if (obj.Code != "0")
            {
                return null;
            }
            User user = JsonConvert.DeserializeObject<User>(obj.Data.ToString());
            return user;
        }

        public static string PostSaveKadaoData(string username, string title, List<Kill> kills)
        {
            var options = new RestClientOptions(url)
            {
                MaxTimeout = -1,
            };
            var client = new RestClient(options);
            var request = new RestRequest(saveKadaoDataUrl, Method.Post);
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddParameter("username", username);
            request.AddParameter("title", title);
            request.AddParameter("data", JsonHelper.JsonSerializer(kills));
            var response = client.Execute(request);
            ResponseBody obj = JsonConvert.DeserializeObject<ResponseBody>(response.Content);
            if (obj.Code != "0")
            {
                return obj.Msg;
            }
            return "";
        }

        public static Data GetMyKadaoDataList(string username, string pageSize, string page)
        {
            var options = new RestClientOptions(url)
            {
                MaxTimeout = -1,
            };
            var client = new RestClient(options);
            string getMyKadaoDataListUrl = string.Format(getMyKadaoDataListUrlFormat, new object[] { username, pageSize, page, pageSize });
            var request = new RestRequest(getMyKadaoDataListUrl, Method.Get);
            var response = client.Execute(request);
            ResponseBodyGetMyKadaoData obj = new ResponseBodyGetMyKadaoData();
            obj = JsonConvert.DeserializeObject<ResponseBodyGetMyKadaoData>(response.Content);
            if (obj.Code != 0 || obj.Data.List.Count < 1)
            {
                return null;
            }
            return obj.Data;
        }
        public static bool DelMyKadaoData(string username, string kid)
        {
            var options = new RestClientOptions(url)
            {
                MaxTimeout = -1
            };
            var client = new RestClient(options);
            var request = new RestRequest(delMyKadaoDataUrl, Method.Post);
            request.AddHeader("Accept", "*/*");
            request.AddHeader("Host", host);
            request.AddHeader("Connection", "keep-alive");
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddParameter("username", username);
            request.AddParameter("kid", kid);
            var response = client.Execute(request);
            ResponseBody obj = JsonConvert.DeserializeObject<ResponseBody>(response.Content);
            if (obj.Code != "0")
            {
                return false;
            }
            return true;
        }

        public static KadaoBiLi GetKadaoBiLi()
        {
            var options = new RestClientOptions(url)
            {
                MaxTimeout = -1,
            };
            var client = new RestClient(options);
            var request = new RestRequest(getKadaoBiLiUrl, Method.Get);
            var response = client.Execute(request);
            ResponseBody obj = new ResponseBody();
            obj.Data = new KadaoBiLi();
            obj = JsonConvert.DeserializeObject<ResponseBody>(response.Content);
            if (obj.Code != "0")
            {
                return null;
            }
            KadaoBiLi kadaoBi = JsonConvert.DeserializeObject<KadaoBiLi>(obj.Data.ToString());
            return kadaoBi;
        }

        public static User ChongZhiKadaoTime(string username, int golds, int czTime)
        {
            var options = new RestClientOptions(url)
            {
                MaxTimeout = -1
            };
            var client = new RestClient(options);
            var request = new RestRequest(chongZhiKadaoTimeUrl, Method.Post);
            request.AddHeader("Accept", "*/*");
            request.AddHeader("Host", host);
            request.AddHeader("Connection", "keep-alive");
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddParameter("username", username);
            request.AddParameter("golds", golds);
            request.AddParameter("kadao_time", czTime);
            var response = client.Execute(request);
            ResponseBody obj = new ResponseBody();
            obj.Data = new User();
            obj = JsonConvert.DeserializeObject<ResponseBody>(response.Content);
            if (obj.Code != "0")
            {
                return null;
            }
            User user = JsonConvert.DeserializeObject<User>(obj.Data.ToString());
            return user;
        }
    }
}
