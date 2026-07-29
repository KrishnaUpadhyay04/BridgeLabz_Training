using System;

class Question3
{
    public static void Solution()
    {
        DateTime currentTime =  DateTime.Now;

        Console.WriteLine("Current Date in Different Formats: \n");

        Console.WriteLine("dd/MM/yyyy " + currentTime.ToString("dd/MM/yyyy"));
        Console.WriteLine("yyyy-MM-dd " + currentTime.ToString("yyyy-MM-dd"));
        Console.WriteLine("ddd, MMM dd, yyyy" + currentTime.ToString("ddd, MM dd, yyyy")); //ddd tells the day of the week (EEE is for JAVA).
    }
}