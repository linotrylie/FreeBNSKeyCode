using System;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;

namespace FreeBNS.Utils
{
    /// <summary>
    /// Json序列化帮助类
    /// 提供一系列的关于Json序列化/反序列化的操作
    public class JsonHelper
    {
        /// <summary>
        /// 原始泛型对象序列化为Json字符串，返回序列化后的Json字符串
        /// 序列化失败则返回null
        /// </summary>
        ///  Shopping.SpecificationsList list = Njson.json.JsonDeserialize<Shopping.SpecificationsList>(Json_str);
        /// <typeparam name="T">序列化的类型</typeparam>
        /// <param name="t">原始泛型对象</param>
        /// <returns>序列化后的Json字符串</returns>
        public static string JsonSerializer<T>(T t)
        {

            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(T));

            MemoryStream ms = new MemoryStream();

            ser.WriteObject(ms, t);

            string jsonString = Encoding.UTF8.GetString(ms.ToArray());

            ms.Close();

            return jsonString;

        }



        /// <summary>
        /// 原始Json字符串反序列化为泛型对象，返回反序列化后的泛型对象
        /// 序列化失败则返回泛型默认值
        /// </summary>
        /// <typeparam name="T">反序列化的类型</typeparam>
        /// <param name="jsonString">原始Json字符串</param>
        /// <returns>反序列化后的泛型对象</returns>

        public static T JsonDeserialize<T>(string jsonString)
        {
            //处理错误参数
            if (String.IsNullOrEmpty(jsonString))
            {
                return default(T);
            }
            else { }

            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(T));

            MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(jsonString));

            T obj = (T)ser.ReadObject(ms);

            return obj;

        }
    }
}
