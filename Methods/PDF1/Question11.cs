using System;

public class Question11
{
    public static void Run()
    {
        Console.WriteLine("Question 11: Wind chill temperature");
        Console.Write("Enter temperature: ");
        double temperature = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter wind speed: ");
        double windSpeed = Convert.ToDouble(Console.ReadLine());

        double windChill = Program.CalculateWindChill(temperature, windSpeed);
        Console.WriteLine($"Wind chill temperature: {windChill}");
    }
}
