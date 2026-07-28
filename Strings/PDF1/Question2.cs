using System;

public class Question2
{
    public static void Run()
    {
        Console.WriteLine("Question 2: Reverse a String");
        Console.Write("Enter a string: ");
        string input = Console.ReadLine() ?? string.Empty;

        string reversed = Program.ReverseString(input);
        Console.WriteLine($"Reversed string: {reversed}");
    }
}
