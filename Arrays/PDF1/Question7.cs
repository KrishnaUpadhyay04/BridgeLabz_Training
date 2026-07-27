using System;

class Question7
{
    public static void Solution()
    {
        Console.WriteLine("Enter a number");
        int number = Convert.ToInt32(Console.ReadLine());

        int[] odd = new int[number / 2 + 1];
        int[] even = new int[number / 2 + 1];

        int oddIdx = 0, evenIdx = 0;

        for (int i = 1; i <= number; i++)
        {
            if (i % 2 == 0) even[evenIdx++] = i;
            else odd[oddIdx++] = i;
        }

        Console.WriteLine($"Odd numbers till {number} are:");
        for (int i = 0; i < oddIdx; i++)
        {
            Console.Write(odd[i] + " ");
        }

        Console.WriteLine();
        Console.WriteLine($"Even numbers till {number} are:");
        for (int i = 0; i < evenIdx; i++)
        {
            Console.Write(even[i] + " ");
        }
    }
}