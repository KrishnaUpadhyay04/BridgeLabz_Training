using System;

public class Question1
{
    public static void Run()
    {
        Console.WriteLine("Question 1: Factors of a number");
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int[] factors = Program.FindFactors(number);
        Console.WriteLine("Factors:");
        foreach (int factor in factors)
        {
            Console.Write(factor + " ");
        }
        Console.WriteLine();

        Console.WriteLine($"Sum of factors: {Program.FindSumOfFactors(factors)}");
        Console.WriteLine($"Sum of squares of factors: {Program.FindSumOfSquaresOfFactors(factors)}");
        Console.WriteLine($"Product of factors: {Program.FindProductOfFactors(factors)}");
    }
}
