using System;

public class Question9
{
    public static void Run()
    {
        Console.WriteLine("Question 9: Positive/negative and even/odd analysis");
        int[] numbers = new int[5];
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write($"Enter number {i + 1}: ");
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }

        for (int i = 0; i < numbers.Length; i++)
        {
            if (Program.IsPositive(numbers[i]))
            {
                Console.WriteLine($"{numbers[i]} is positive and {Program.IsEven(numbers[i])}");
            }
            else
            {
                Console.WriteLine($"{numbers[i]} is negative");
            }
        }

        int comparison = Program.CompareNumbers(numbers[0], numbers[^1]);
        if (comparison == 1)
        {
            Console.WriteLine("First element is greater than last element");
        }
        else if (comparison == 0)
        {
            Console.WriteLine("First and last elements are equal");
        }
        else
        {
            Console.WriteLine("First element is less than last element");
        }
    }
}
