using System;

namespace FreeBNS.Utils
{
    public static class TimeHelper
    {
        /// <summary>
        /// 获取现在时间戳，秒
        /// </summary>
        /// <returns></returns>
        public static string GetTimeStamp()
        {
            return DateTimeOffset.Now.ToUnixTimeSeconds().ToString();
        }

        /// <summary>
        /// 获取现在时间戳，毫秒
        /// </summary>
        /// <returns></returns>
        public static string GetMilliTimeStamp()
        {
            return DateTimeOffset.UtcNow.ToUnixTimeMilliseconds().ToString();
        }

        /// <summary>
        /// 日期转时间戳 ， 精确到秒
        /// </summary>
        /// <returns></returns>
        public static string ToSecondsTimeStamp(this DateTime dateTime)
        {
            return ((dateTime.ToUniversalTime().Ticks - 621355968000000000) / 10000000).ToString();
        }

        /// <summary>
        /// 日期转时间戳 ， 精确到毫秒
        /// </summary>
        /// <returns></returns>
        public static string ToMillisecondsTimeStamp(this DateTime dateTime)
        {
            return ((dateTime.ToUniversalTime().Ticks - 621355968000000000) / 10000).ToString();
        }
        /// <summary>
        /// 计算一个时间戳与当前时间的间隔
        /// </summary>
        ///<param name="timeStamp"></param>
        /// <returns></returns>
        public static TimeSpan GetTimeSpan(string timeStamp)
        {
            long lTime = long.Parse(timeStamp);
            var DateTimeUnix = DateTimeOffset.FromUnixTimeSeconds(lTime);
            //计算两个时间间隔
            TimeSpan timeSpan = new TimeSpan(DateTimeOffset.UtcNow.Ticks - DateTimeUnix.Ticks);
            return timeSpan;
        }

        /// <summary>
        /// 计算两个时间戳的间隔
        /// </summary>
        ///<param name="timeStamp1"></param>
        ///<param name="timeStamp2"></param>
        /// <returns></returns>
        public static TimeSpan GetTwoTimeSpan(string timeStamp1, string timeStamp2)
        {
            //获取时间戳，并将其转换为DateTimeOffset
            //var UninTimeStamp = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
            long lTime1 = long.Parse(timeStamp1);
            long lTime2 = long.Parse(timeStamp2);
            var DateTimeUnix1 = DateTimeOffset.FromUnixTimeSeconds(lTime1);
            var DateTimeUnix2 = DateTimeOffset.FromUnixTimeSeconds(lTime2);
            //计算两个时间间隔
            TimeSpan timeSpan = new TimeSpan(DateTimeUnix2.Ticks - DateTimeUnix1.Ticks);
            return timeSpan;
        }

        /// <summary>  
        /// 时间戳Timestamp转换成日期  
        /// </summary>  
        /// <param name="timeStamp"></param>  
        /// <returns></returns>  
        public static DateTime GetDateTime(int timeStamp)
        {
            DateTime dtStart = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1));
            long lTime = ((long)timeStamp * 10000000);
            TimeSpan toNow = new TimeSpan(lTime);
            DateTime targetDt = dtStart.Add(toNow);
            return targetDt;
        }
    }
}
