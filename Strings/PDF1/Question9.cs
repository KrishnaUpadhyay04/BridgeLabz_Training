using System;

public class Question9
{
    public static void Run()
    {
        Console.WriteLine("Question 9: Find the Most Frequent Character");
        Console.Write("Enter a string: ");
        string input = Console.ReadLine() ?? string.Empty;

        char mostFrequent = Program.FindMostFrequentCharacter(input);
        Console.WriteLine($"Most frequent character: '{mostFrequent}'");
    }
}
