using System;

class Question8
{
    public static void Solution()
    {
        Console.WriteLine("Enter the number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        int[] factors = new int[number];
        int idx = 0;

        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0) factors[idx++] = i;
        }

        Console.WriteLine($"Factors of {number} are:");
        for (int i = 0; i < idx; i++)
        {
            Console.Write(factors[i] + " ");
        }
    }
}