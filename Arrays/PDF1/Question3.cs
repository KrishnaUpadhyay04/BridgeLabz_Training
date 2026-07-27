using System;

class Question3
{
    public static void Solution()
    {
        int[] table = new int[10];
        Console.WriteLine("Enter the number you want table of: ");
        int number = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < 10; i++)
        {
            table[i] = number * (i + 1);
            Console.WriteLine($"{number} * {i + 1} = {table[i]}");
        }
    }
}