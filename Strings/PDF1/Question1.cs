using System;

public class Question1
{
    public static void Run()
    {
        Console.WriteLine("Question 1: Count Vowels and Consonants");
        Console.Write("Enter a string: ");
        string input = Console.ReadLine() ?? string.Empty;

        int vowels = Program.CountVowels(input);
        int consonants = Program.CountConsonants(input);

        Console.WriteLine($"Vowels: {vowels}");
        Console.WriteLine($"Consonants: {consonants}");
    }
}
