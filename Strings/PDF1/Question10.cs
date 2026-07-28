using System;

public class Question10
{
    public static void Run()
    {
        Console.WriteLine("Question 10: Remove a Specific Character from a String");
        Console.Write("Enter a string: ");
        string input = Console.ReadLine() ?? string.Empty;
        Console.Write("Enter character to remove: ");
        char character = Console.ReadLine()?[0] ?? ' ';

        string result = Program.RemoveCharacter(input, character);
        Console.WriteLine($"Modified string: {result}");
    }
}
