using System;

public class Question12
{
    public static void Run()
    {
        Console.WriteLine("Question 12: Trigonometric functions");
        Console.Write("Enter angle in degrees: ");
        double angle = Convert.ToDouble(Console.ReadLine());

        double[] values = Program.CalculateTrigonometricFunctions(angle);
        Console.WriteLine($"Sine: {values[0]}, Cosine: {values[1]}, Tangent: {values[2]}");
    }
}
