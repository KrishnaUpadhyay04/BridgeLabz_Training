using System;

public class Question5
{
    public static void Run()
    {
        Console.WriteLine("Question 5: Unit Converter - Length");
        Console.Write("Enter yards: ");
        double yards = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"{yards} yards = {Program.ConvertYardsToFeet(yards)} feet");

        Console.Write("Enter feet: ");
        double feet = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"{feet} feet = {Program.ConvertFeetToYards(feet)} yards");

        Console.Write("Enter meters: ");
        double meters = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"{meters} meters = {Program.ConvertMetersToInches(meters)} inches");

        Console.Write("Enter inches: ");
        double inches = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"{inches} inches = {Program.ConvertInchesToMeters(inches)} meters");
        Console.WriteLine($"{inches} inches = {Program.ConvertInchesToCentimeters(inches)} cm");
    }
}
