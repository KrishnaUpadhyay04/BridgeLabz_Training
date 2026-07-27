using System;

public class Question7
{
    public static void Run()
    {
        Console.WriteLine("Question 7: Sum of first n natural numbers");
        Console.Write("Enter n: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int sum = Program.SumOfNaturalNumbers(n);
        Console.WriteLine($"The sum of first {n} natural numbers is {sum}");
    }
}
