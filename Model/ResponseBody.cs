using Newtonsoft.Json;
using System;
namespace FreeBNS.Model
{
    public class ResponseBody
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("msg")]
        public string Msg { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("data")]
        public Object Data { get; set; }
    }

    public class KadaoBiLi
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("golds")]
        public int Golds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("time")]
        public int Time { get; set; }
    }

}
