using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
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
}
