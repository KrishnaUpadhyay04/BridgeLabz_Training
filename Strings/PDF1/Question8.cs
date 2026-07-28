using System;

public class Question8
{
    public static void Run()
    {
        Console.WriteLine("Question 8: Compare Two Strings");
        Console.Write("Enter string 1: ");
        string first = Console.ReadLine() ?? string.Empty;
        Console.Write("Enter string 2: ");
        string second = Console.ReadLine() ?? string.Empty;

        int comparison = Program.CompareStrings(first, second);
        if (comparison < 0)
        {
            Console.WriteLine($"{first} comes before {second} in lexicographical order");
        }
        else if (comparison > 0)
        {
            Console.WriteLine($"{second} comes before {first} in lexicographical order");
        }
        else
        {
            Console.WriteLine("Both strings are equal");
        }
    }
}
