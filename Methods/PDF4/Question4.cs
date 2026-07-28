using System;

public class Question4
{
    public static void Run()
    {
        Console.WriteLine("Question 4: Palindrome and duck number");
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int[] digits = Program.StoreDigits(number);
        int[] reversed = Program.ReverseDigits(digits);
        Console.WriteLine($"Reversed digits: {string.Join(", ", reversed)}");
        Console.WriteLine($"Arrays equal: {Program.AreArraysEqual(digits, reversed)}");
        Console.WriteLine($"Palindrome: {Program.IsPalindrome(number, digits)}");
        Console.WriteLine($"Duck number: {Program.IsDuckNumber(number, digits)}");
    }
}
