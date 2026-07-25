using System;

class Question1
{
    public static void Solution()
    {
        Console.WriteLine("Enter Principal amount: ");
        double principal = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter rate of interest: ");
        double rate = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter time in years: ");
        int time = Convert.ToInt32(Console.ReadLine());
        double simpleInterest = (principal * rate * time) / 100;
        Console.WriteLine($"Simple Interest is: {simpleInterest}");
    }
}