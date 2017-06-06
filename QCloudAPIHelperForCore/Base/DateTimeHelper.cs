using System;

namespace QCloudAPIHelperForCore.Base
{
    public static class DateTimeHelper
    {
        /// <summary>
        /// 将UNIX时间戳转为时间
        /// </summary>
        /// <param name="timeStamp"></param>
        /// <returns></returns>
        public static DateTime StampToDateTime(this string timeStamp)
        {
            // .NET Version >= 4.6 can use
            long lTime = long.Parse(timeStamp + "0000000");
            return DateTimeOffset.FromUnixTimeSeconds(lTime).LocalDateTime;
        }

        /// <summary>
        /// 将DateTime时间格式转换为Unix时间戳格式
        /// </summary>
        /// <param name="time"></param>
        /// <returns></returns>
        public static int DateTimeToStamp(this DateTime time)
        {
            // https://msdn.microsoft.com/en-us/library/system.datetimeoffset.tounixtimeseconds(v=vs.110).aspx
            // .NET Version >= 4.6 can use
            return (Int32)new DateTimeOffset(time).ToUnixTimeSeconds();
        }

        /// <summary>
        /// 转换时间为QCloud定义的时间格式
        /// </summary>
        /// <param name="time"></param>
        /// <returns></returns>
        public static string DateTimeConvertQCloudFormat(this DateTime time)
        {
            return time.ToString("yyyy-MM-dd HH:mm:ss");
        }

        /// <summary>  
        /// 取得某月的第一天  
        /// </summary>  
        /// <param name="datetime">要取得月份第一天的时间</param>  
        /// <returns></returns>  
        public static DateTime FirstDayOfMonth(this DateTime datetime)
        {
            return datetime.AddDays(1 - datetime.Day);
        }

        /// <summary>
        /// 取得某月的最后一天  
        /// </summary>  
        /// <param name="datetime">要取得月份最后一天的时间</param>  
        /// <returns></returns>
        public static DateTime LastDayOfMonth(this DateTime datetime)
        {
            return datetime.AddDays(1 - datetime.Day).AddMonths(1).AddDays(-1);
        }

        /// <summary>  
        /// 取得上个月第一天  
        /// </summary>  
        /// <param name="datetime">要取得上个月第一天的当前时间</param>  
        /// <returns></returns> 
        public static DateTime FirstDayOfPreviousMonth(this DateTime datetime)
        {
            return datetime.AddDays(1 - datetime.Day).AddMonths(-1);
        }

        /// <summary>  
        /// 取得上个月的最后一天  
        /// </summary>  
        /// <param name="datetime">要取得上个月最后一天的当前时间</param>  
        /// <returns></returns>  
        public static DateTime LastDayOfPrdviousMonth(this DateTime datetime)
        {
            return datetime.AddDays(1 - datetime.Day).AddDays(-1);
        }

        /// <summary>  
        /// 取得前一天  
        /// </summary>  
        /// <param name="datetime">要取得上个月最后一天的当前时间</param>  
        /// <returns></returns>  
        public static DateTime LastDay(this DateTime datetime)
        {
            return datetime.AddDays(-1);
        }


        /// <summary>  
        /// 取得前10分钟 
        /// </summary>  
        /// <param name="datetime">要取得上个月最后一天的当前时间</param>  
        /// <returns></returns>  
        public static DateTime LastTenMinutes(this DateTime datetime)
        {
            return datetime.AddMinutes(-10);
        }
    }
}
