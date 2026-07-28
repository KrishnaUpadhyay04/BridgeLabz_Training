using System;

public class Question12
{
    public static void Run()
    {
        Console.WriteLine("Question 12: Replace a Word in a Sentence");
        Console.Write("Enter a sentence: ");
        string sentence = Console.ReadLine() ?? string.Empty;
        Console.Write("Enter word to replace: ");
        string oldWord = Console.ReadLine() ?? string.Empty;
        Console.Write("Enter replacement word: ");
        string newWord = Console.ReadLine() ?? string.Empty;

        string result = Program.ReplaceWord(sentence, oldWord, newWord);
        Console.WriteLine($"Modified sentence: {result}");
    }
}
