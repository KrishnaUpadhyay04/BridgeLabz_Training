using System;

public class Question5
{
    public static void Run()
    {
        Console.WriteLine("Question 5: Find the Longest Word in a Sentence");
        Console.Write("Enter a sentence: ");
        string input = Console.ReadLine() ?? string.Empty;

        string longestWord = Program.FindLongestWord(input);
        Console.WriteLine($"Longest word: {longestWord}");
    }
}
