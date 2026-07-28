using System;

public class Question7
{
    public static void Run()
    {
        Console.WriteLine("Question 7: Toggle Case of Characters");
        Console.Write("Enter a string: ");
        string input = Console.ReadLine() ?? string.Empty;

        string toggled = Program.ToggleCase(input);
        Console.WriteLine($"Toggled string: {toggled}");
    }
}
