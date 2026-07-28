using System;

public class Question6
{
    public static void Run()
    {
        Console.WriteLine("Question 6: Find Substring Occurrences");
        Console.Write("Enter a string: ");
        string input = Console.ReadLine() ?? string.Empty;
        Console.Write("Enter a substring: ");
        string substring = Console.ReadLine() ?? string.Empty;

        int count = Program.CountSubstringOccurrences(input, substring);
        Console.WriteLine($"Occurrences: {count}");
    }
}
