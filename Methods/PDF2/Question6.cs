using System;

public class Question6
{
    public static void Run()
    {
        Console.WriteLine("Question 6: Unit Converter - Temperature/Weight/Volume");
        Console.Write("Enter Fahrenheit: ");
        double fahrenheit = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"{fahrenheit} F = {Program.ConvertFahrenheitToCelsius(fahrenheit)} C");

        Console.Write("Enter Celsius: ");
        double celsius = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"{celsius} C = {Program.ConvertCelsiusToFahrenheit(celsius)} F");

        Console.Write("Enter pounds: ");
        double pounds = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"{pounds} lb = {Program.ConvertPoundsToKilograms(pounds)} kg");

        Console.Write("Enter kilograms: ");
        double kilograms = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"{kilograms} kg = {Program.ConvertKilogramsToPounds(kilograms)} lb");

        Console.Write("Enter gallons: ");
        double gallons = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"{gallons} gallons = {Program.ConvertGallonsToLiters(gallons)} liters");

        Console.Write("Enter liters: ");
        double liters = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"{liters} liters = {Program.ConvertLitersToGallons(liters)} gallons");
    }
}
