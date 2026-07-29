using System;
using System.Security.Cryptography;

public class Question5
{
    public static void Solution()
    {
        string text = GetInput();

        bool isPalindrome = CheckPalindrome(text);

        DisplayResult(text, isPalindrome);
    }

    static string GetInput()
    {
        Console.Write("Enter a string: ");
        return Console.ReadLine();
    }

    static bool CheckPalindrome(string text)
    {
        int left = 0;
        int right = text.Length - 1;

        while(left < right)
        {
            if(text[left] != text[right]) return false;

            left++;
            right--;
        }

        return true;
    }

    static void DisplayResult(string text, bool isPalindrome)
    {
        if(isPalindrome) Console.WriteLine($"\n\"{text}\" is a palindrome");
        else Console.WriteLine($"\n\"{text}\" is not a palindrome");
    }
}