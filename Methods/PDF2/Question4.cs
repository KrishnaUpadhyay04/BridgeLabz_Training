using System;

public class Question4
{
    public static void Run()
    {
        Console.WriteLine("Question 4: Unit Converter - Distance");
        Console.Write("Enter kilometers: ");
        double km = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"{km} km = {Program.ConvertKmToMiles(km)} miles");

        Console.Write("Enter miles: ");
        double miles = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"{miles} miles = {Program.ConvertMilesToKilometers(miles)} km");

        Console.Write("Enter meters: ");
        double meters = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"{meters} meters = {Program.ConvertMetersToFeet(meters)} feet");

        Console.Write("Enter feet: ");
        double feet = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"{feet} feet = {Program.ConvertFeetToMeters(feet)} meters");
    }
}
