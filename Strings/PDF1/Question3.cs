using System;

public class Question3
{
    public static void Run()
    {
        Console.WriteLine("Question 3: Palindrome String Check");
        Console.Write("Enter a string: ");
        string input = Console.ReadLine() ?? string.Empty;

        bool isPalindrome = Program.IsPalindrome(input);
        Console.WriteLine($"Palindrome: {isPalindrome}");
    }
}
