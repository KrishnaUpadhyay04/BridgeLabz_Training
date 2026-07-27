using System;

public class Question1
{
    public static void Run()
    {
        Console.WriteLine("Question 1: Simple Interest");
        Console.Write("Enter principal: ");
        double principal = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter rate: ");
        double rate = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter time: ");
        double time = Convert.ToDouble(Console.ReadLine());

        double simpleInterest = Program.CalculateSimpleInterest(principal, rate, time);
        Console.WriteLine($"The Simple Interest is {simpleInterest} for Principal {principal}, Rate of Interest {rate} and Time {time}");
    }
}
