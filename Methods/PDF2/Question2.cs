using System;

public class Question2
{
    public static void Run()
    {
        Console.WriteLine("Question 2: Sum of natural numbers recursively");
        Console.Write("Enter n: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int recursiveSum = Program.SumNaturalNumbersRecursive(n);
        int formulaSum = Program.SumNaturalNumbersFormula(n);

        Console.WriteLine($"Recursive sum: {recursiveSum}");
        Console.WriteLine($"Formula sum: {formulaSum}");
        Console.WriteLine(recursiveSum == formulaSum ? "Both results are correct" : "Results do not match");
    }
}
