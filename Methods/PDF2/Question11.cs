using System;

public class Question11
{
    public static void Run()
    {
        Console.WriteLine("Question 11: Quadratic equation roots");
        Console.Write("Enter a: ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter b: ");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter c: ");
        double c = Convert.ToDouble(Console.ReadLine());

        double[] roots = Program.FindQuadraticRoots(a, b, c);
        if (roots.Length == 0)
        {
            Console.WriteLine("No real roots");
        }
        else if (roots.Length == 1)
        {
            Console.WriteLine($"Single root: {roots[0]}");
        }
        else
        {
            Console.WriteLine($"Root 1: {roots[0]}");
            Console.WriteLine($"Root 2: {roots[1]}");
        }
    }
}
