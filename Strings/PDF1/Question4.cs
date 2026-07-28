using System;

public class Question4
{
    public static void Run()
    {
        Console.WriteLine("Question 4: Remove Duplicates from a String");
        Console.Write("Enter a string: ");
        string input = Console.ReadLine() ?? string.Empty;

        string result = Program.RemoveDuplicates(input);
        Console.WriteLine($"Modified string: {result}");
    }
}
