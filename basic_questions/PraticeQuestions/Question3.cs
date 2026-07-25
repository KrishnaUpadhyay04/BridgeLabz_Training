using System;

class Question3
{
    public static void Solution()
    {
        Console.WriteLine("Enter the base: ");
        int number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the exponent: ");
        int exponent = Convert.ToInt32(Console.ReadLine());
        double result = Math.Pow(number, exponent);
        Console.WriteLine($"Result is: {result}");
    }
}