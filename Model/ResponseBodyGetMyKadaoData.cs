using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace FreeBNS.Model
{
    public class Data
    {
        /// <summary>
		/// 
		/// </summary>
		[JsonProperty("list")]
        public List<MyKadaoData> List { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("total")]
        public int Total { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("total_page")]
        public int TotalPage { get; set; }
    }
    public class MyKadaoData
    {
        /// <summary>
		/// 
		/// </summary>
		[JsonProperty("kid")]
        public string Kid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("uid")]
        public string Uid { get; set; }

        /// <summary>
        /// 测试01
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("data")]
        public string Data { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("is_share")]
        public string IsShare { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("create_time")]
        public DateTime CreateTime { get; set; }
    }

    public class ResponseBodyGetMyKadaoData
    {
        /// <summary>
		/// 
		/// </summary>
		[JsonProperty("code")]
        public int Code { get; set; }

        /// <summary>
        /// 请求成功
        /// </summary>
        [JsonProperty("msg")]
        public string Msg { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("data")]
        public Data Data { get; set; }
    }
}
