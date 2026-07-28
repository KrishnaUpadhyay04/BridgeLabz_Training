using System;

public class Question11
{
    public static void Run()
    {
        Console.WriteLine("Question 11: Check if Two Strings are Anagrams");
        Console.Write("Enter first string: ");
        string first = Console.ReadLine() ?? string.Empty;
        Console.Write("Enter second string: ");
        string second = Console.ReadLine() ?? string.Empty;

        bool isAnagram = Program.AreAnagrams(first, second);
        Console.WriteLine($"Anagram: {isAnagram}");
    }
}
