using System;

public class Question7
{
    public static void Solution()
    {
        int num1 = GetNumber("Enter the first number: ");
        int num2 = GetNumber("Enter the second number: ");

        int gcd = FindGCD(num1, num2);
        int lcm = FindLCM(num1, num2);

        DisplayResult(gcd, lcm);
    }

    static int GetNumber(string message)
    {
        Console.Write(message);
        return Convert.ToInt32(Console.ReadLine());
    }

    static int FindGCD(int a, int b)
    {
        while(b != 0)
        {
            int remainder = a % b;
            a = b;
            b = remainder;
        }

        return a;
    }

    static int FindLCM(int a, int b)
    {
        return (a * b) / FindGCD(a, b);
    }

    static void DisplayResult(int gcd, int lcm)
    {
        Console.WriteLine($"\nGreatest Common Divisor (GCD): {gcd}");
        Console.WriteLine($"Least Common Multiple (LCM): {lcm}");
    }
}