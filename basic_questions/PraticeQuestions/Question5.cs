using System;

class Question5
{
    public static void Solution()
    {
        Console.WriteLine("Enter distnace in km: ");
        double distance = Convert.ToDouble(Console.ReadLine());
        double miles = distance * 0.621371;

        Console.WriteLine($"Distance in miles is: {miles}");
    }
}