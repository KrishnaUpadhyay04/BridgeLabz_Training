using System;
using System.ComponentModel.DataAnnotations;

public class Question8
{
    public static void Solution()
    {
        Console.WriteLine("Temperature Conversion");
        Console.WriteLine("1. Celsius to Farenheit");
        Console.WriteLine("2. Farenheit to Celsius");
        Console.Write("Choose your conversion(1 or 2): ");
        int convert = Convert.ToInt32(Console.ReadLine());

        if(convert == 1)
        {
            Console.Write("Enter the temperature: ");
            double temp = Convert.ToDouble(Console.ReadLine());
            DisplayConversion(convert, temp, ConvertCelsiusToFarenheit(temp));
        }

        else if(convert == 2)
        {
            Console.Write("Enter the temperature: ");
            double temp = Convert.ToDouble(Console.ReadLine());
            DisplayConversion(convert, temp, ConvertFarenheitToCelsius(temp));
        }

        else Console.WriteLine("Invalid Choice!");
    }

    public static double ConvertCelsiusToFarenheit(double temp)
    {
        return (temp * 9 / 5) + 32;
    }

    public static double ConvertFarenheitToCelsius(double temp)
    {
        return (temp - 32) * 5 / 9;
    }

    public static void DisplayConversion(int convert, double temp, double converted)
    {
        if(convert == 1) Console.WriteLine($"{temp} in Farenheit is: {converted}");

        else Console.WriteLine($"{temp} in Celsius is: {converted}");
    }
}