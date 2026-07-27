using System;
using System.Globalization;

class Question5
{
    public static void Solution()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int[] multiplicationResult = new int[4];

        for(int i = 6; i<= 9; i++) multiplicationResult[i - 6] = number * i;

        Console.WriteLine("\nMultiplication Table: ");
        for(int i = 6; i<= 9; i++)
        {
            Console.WriteLine($"{number} * {i} = {multiplicationResult[i - 6]}");
        }
    }
}