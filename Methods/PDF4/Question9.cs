using System;

public class Question9
{
    public static void Run()
    {
        Console.WriteLine("Question 9: Line and distance between points");
        Console.Write("Enter x1: ");
        double x1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter y1: ");
        double y1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter x2: ");
        double x2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter y2: ");
        double y2 = Convert.ToDouble(Console.ReadLine());

        double distance = Program.FindDistance(x1, y1, x2, y2);
        double[] equation = Program.FindLineEquation(x1, y1, x2, y2);

        Console.WriteLine($"Distance: {distance}");
        Console.WriteLine($"Line equation: y = {equation[0]}x + {equation[1]}");
    }
}
