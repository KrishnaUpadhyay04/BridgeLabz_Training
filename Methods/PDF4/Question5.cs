using System;

public class Question5
{
    public static void Run()
    {
        Console.WriteLine("Question 5: Number properties");
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Prime: {Program.IsPrime(number)}");
        Console.WriteLine($"Neon: {Program.IsNeonNumber(number)}");
        Console.WriteLine($"Spy: {Program.IsSpyNumber(number)}");
        Console.WriteLine($"Automorphic: {Program.IsAutomorphicNumber(number)}");
        Console.WriteLine($"Buzz: {Program.IsBuzzNumber(number)}");
    }
}
