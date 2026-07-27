using System;

class Question2
{
    public static void Solution()
    {
        int[] numbers = new int[5];
        Console.WriteLine("Enter the numbers");
        for(int i = 0; i < 5; i++)
        {
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }

        for(int i = 0; i < 5; i++)
        {
            if(numbers[i] > 0)
            {
                if(numbers[i] % 2 != 0) Console.WriteLine("Odd");
                else Console.WriteLine("Even");
            }

            else if(numbers[i] < 0) Console.WriteLine("Negative");

            else Console.WriteLine("Zero");
        }

        if(numbers[0] == numbers[4]) Console.WriteLine("Equal");
        else Console.WriteLine((numbers[0] > numbers[4]) ? "Greater" : "Lesser");
    }
}