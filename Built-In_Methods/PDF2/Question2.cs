using System;

public class Question2
{
    public static void Solution()
    {
        Console.WriteLine("Enter the first number: ");
        int num1 = GetNumber();
        Console.WriteLine("Enter the second number: ");
        int num2 = GetNumber();
        Console.WriteLine("Enter the third number: ");
        int num3 = GetNumber();

        int maximum = GetMax(num1, num2, num3);

        Console.WriteLine($"The maximum number out of the three is: {maximum}");
    }

    static int GetNumber()
    {
        return Convert.ToInt32(Console.ReadLine());
    }

    static int GetMax(int num1, int num2, int num3)
    {
        int max = num1;
        if(num2 > max) max = num2;
        if(num3 > max) max = num3;

        return max;
    }
}