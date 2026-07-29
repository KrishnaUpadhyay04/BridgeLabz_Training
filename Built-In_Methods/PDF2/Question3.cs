using System;

public class Question3
{
    public static void Solution()
    {
        Console.WriteLine("Enter the number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        if(CheckPrime(num)) Console.WriteLine($"{num} is a prime number");

        else Console.WriteLine($"{num} is not a prime number");
    }

    static bool CheckPrime(int num)
    {
        if(num < 2) return false;
        if(num == 2) return true;

        for(int i = 3; i * i <= num; i++)
        {
            if(num % i == 0) return false;
        }

        return true;
    }
}