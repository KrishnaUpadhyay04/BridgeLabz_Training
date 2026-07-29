using System;

class Question1
{
    public static void Solution()
    {
        // cuurent time with offset
        DateTimeOffset currentTime = DateTimeOffset.Now;

        // GMT (UTC)
        TimeZoneInfo gmt = TimeZoneInfo.Utc;

        // IST (Indian Standard Time)
        TimeZone ist = TimeZoneInfo.FindSystemTimeZoneById("Indian Standard Time");

        // PST (Pacific Standard Time)
        // Windows Time Zone ID
        TimeZoneInfo pst = TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time");

        // Convert current time to different time zones
        DateTimeOffset gmtTime = TimeZoneInfo.ConvertTime(currentTime, gmt); 
        DateTimeOffset istTime = TimeZoneInfo.ConvertTime(currentTime, ist);
        DateTimeOffset pstTime = TimeZoneInfo.ConvertTime(currentTime, pst);

        Console.WriteLine("Current Time in Different Time Zones");
        Console.WriteLine();
        Console.WriteLine($"GMT: {gmtTime}");
        Console.WriteLine($"IST: {istTime}");
        Console.WriteLine($"PST: {pstTime}");
    }
}