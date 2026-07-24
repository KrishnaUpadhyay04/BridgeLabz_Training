using System;

class Question7
{
    public static void Solution()
    {
        Console.Write("Enter first number: ");
        int number1 = int.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        int number2 = int.Parse(Console.ReadLine());

        int temp = number1;
        number1 = number2;
        number2 = temp;

        Console.WriteLine($"The swapped numbers are {number1} and {number2}");
    }
}
