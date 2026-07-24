using System;

class Question1
{
    public static void Solution()
    {
        Console.WriteLine("Enter First Number: ");
        int firstNumber = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter Second Number: ");
        int secondNumber = Convert.ToInt32(Console.ReadLine());

        int quotient = firstNumber / secondNumber;
        int remainder = firstNumber % secondNumber;

        Console.WriteLine($"The Quotient is {quotient} and Remainder is {remainder} of two numbers {firstNumber} and {secondNumber}");
    }
}