using System;

public class Question4
{
    public static void Solution()
    {
        int terms = GetNumber();

        Console.WriteLine("\nFibonacci Sequence: ");
        PrintFibonacci(terms);
    }

    static int GetNumber()
    {
        Console.Write("Enter the number of terms: ");
        return Convert.ToInt32(Console.ReadLine());
    }

    static void PrintFibonacci(int terms)
    {
        if(terms <= 0)
        {
            Console.WriteLine("Please enter a positive number.");
            return;
        }

        int first = 0;
        int second = 1;

        for(int i = 1; i <= terms; i++)
        {
            Console.Write(first + " ");
            int next = first + second;
            first = second;
            second = next;
        }

        Console.WriteLine();
    }
}