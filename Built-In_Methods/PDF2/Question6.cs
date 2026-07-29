using System;

public class Question6
{
    public static void Solution()
    {
        int number = GetNumber();

        int fact = Factorial(number);

        PrintFactorial(number, fact);
    }

    static int GetNumber()
    {
        Console.Write("Enter the number: ");
        return Convert.ToInt32(Console.ReadLine());
    }

    static int Factorial(int number)
    {
        if(number < 0) return 0;
        if(number <= 1) return 1;

        return number * Factorial(number - 1);
    }

    static void PrintFactorail(int number, int fact)
    {
        Console.WriteLine($"Factorial of {number} is: {fact}");
    }
}