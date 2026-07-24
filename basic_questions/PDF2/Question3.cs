using System;

class Question3
{
    public static void Solution()
    {
        Console.Write("Enter value for a: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Enter value for b: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Enter value for c: ");
        double c = double.Parse(Console.ReadLine());

        double result1 = a + b * c;
        double result2 = a * b + c;
        double result3 = c + a / b;
        double result4 = a % b + c;

        Console.WriteLine($"The results of Double Operations are {result1}, {result2}, {result3}, and {result4}");
    }
}
