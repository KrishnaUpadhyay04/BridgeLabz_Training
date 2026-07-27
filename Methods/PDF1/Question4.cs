using System;

public class Question4
{
    public static void Run()
    {
        Console.WriteLine("Question 4: Rounds for 5 km run");
        Console.Write("Enter side 1 (meters): ");
        double side1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter side 2 (meters): ");
        double side2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter side 3 (meters): ");
        double side3 = Convert.ToDouble(Console.ReadLine());

        int rounds = Program.CalculateRoundsFor5Km(side1, side2, side3);
        Console.WriteLine($"The athlete needs {rounds} round(s) to complete 5 km");
    }
}
