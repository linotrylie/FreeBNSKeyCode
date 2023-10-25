using Newtonsoft.Json;

namespace FreeBNS.Model
{
    public class User
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("uid")]
        public string Uid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("gid")]
        public string Gid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("username")]
        public string Username { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("threads")]
        public string Threads { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("posts")]
        public string Posts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("credits")]
        public string Credits { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("golds")]
        public string Golds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("rmbs")]
        public string Rmbs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("avatar")]
        public string Avatar { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("invitenums")]
        public string Invitenums { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("favorites")]
        public string Favorites { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("kadao_time")]
        public string KadaoTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("notices")]
        public string Notices { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("unread_notices")]
        public string UnreadNotices { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("vip_end")]
        public string VipEnd { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("email_v")]
        public string EmailV { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("digests")]
        public string Digests { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("digests_3")]
        public string Digests3 { get; set; }

        /// <summary>
        /// 人生不过吃喝拉撒睡
        /// </summary>
        [JsonProperty("signature")]
        public string Signature { get; set; }

        /// <summary>
        /// Lv2 初入洪门
        /// </summary>
        [JsonProperty("groupname")]
        public string Groupname { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("avatar_url")]
        public string AvatarUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("avatar_path")]
        public string AvatarPath { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("online_status")]
        public int OnlineStatus { get; set; }
    }
}
