using System;

class Question4
{
    public static void Solution()
    {
        Console.Write("Enter temperature in Celsius: ");
        double celsius = double.Parse(Console.ReadLine());

        double fahrenheitResult = (celsius * 9 / 5) + 32;

        Console.WriteLine($"The {celsius} Celsius is {fahrenheitResult} Fahrenheit");
    }
}
