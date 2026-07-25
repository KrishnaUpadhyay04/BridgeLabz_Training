using System;

class Question4
{
    public static void Solution()
    {
        double number1, number2, number3;
        Console.WriteLine("Enter first number: ");
        number1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter second number: ");
        number2 = Convert.ToDouble(Console.ReadLine()); 
        Console.WriteLine("Enter third number: ");
        number3 = Convert.ToDouble(Console.ReadLine());

        double average = (number1 + number2 + number3) / 3;
        Console.WriteLine($"Average of three numbers is: {average}");
    }
}