using System;

public class Question3
{
    public static void Run()
    {
        Console.WriteLine("Question 3: Digit utilities");
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int[] digits = Program.StoreDigits(number);
        Console.WriteLine($"Sum of digits: {Program.FindSumOfDigits(digits)}");
        Console.WriteLine($"Sum of squares of digits: {Program.FindSumOfSquaresOfDigits(digits)}");
        Console.WriteLine($"Harshad number: {Program.IsHarshadNumber(number, digits)}");
        int[,] frequency = Program.FindDigitFrequency(number);
        Console.WriteLine("Digit frequency:");
        for (int i = 0; i < 10; i++)
        {
            if (frequency[i, 1] > 0)
            {
                Console.WriteLine($"Digit {frequency[i, 0]} -> {frequency[i, 1]}");
            }
        }
    }
}
