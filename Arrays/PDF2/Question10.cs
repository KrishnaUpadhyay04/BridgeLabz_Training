using System;

class Question10
{
    public static void Solution()
    {
        Console.Write("Enter a number: ");
        long number = Convert.ToInt64(Console.ReadLine());

        long temp = number;
        int count = 0;

        while (temp != 0)
        {
            count++;
            temp /= 10;
        }

        int[] digits = new int[count];

        temp = number;

        for (int i = 0; i < count; i++)
        {
            digits[i] = (int)(temp % 10);
            temp /= 10;
        }

        int[] frequency = new int[10];

        for (int i = 0; i < count; i++)
        {
            frequency[digits[i]]++;
        }

        Console.WriteLine("\nDigit Frequency");

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"{i} : {frequency[i]}");
        }
    }
}