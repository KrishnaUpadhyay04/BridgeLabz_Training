using System;

public class Question6
{
    public static void Run()
    {
        Console.WriteLine("Question 6: Factor and number classification");
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int[] factors = Program.FindFactors(number);
        Console.WriteLine($"Factors: {string.Join(", ", factors)}");
        Console.WriteLine($"Greatest factor: {Program.FindGreatestFactor(factors)}");
        Console.WriteLine($"Sum of factors: {Program.FindSumOfFactors(factors)}");
        Console.WriteLine($"Product of factors: {Program.FindProductOfFactors(factors)}");
        Console.WriteLine($"Product of cubes: {Program.FindProductOfCubeOfFactors(factors)}");
        Console.WriteLine($"Perfect: {Program.IsPerfectNumber(number)}");
        Console.WriteLine($"Abundant: {Program.IsAbundantNumber(number)}");
        Console.WriteLine($"Deficient: {Program.IsDeficientNumber(number)}");
        Console.WriteLine($"Strong: {Program.IsStrongNumber(number)}");
    }
}
