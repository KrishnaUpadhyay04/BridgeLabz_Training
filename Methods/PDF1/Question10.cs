using System;

public class Question10
{
    public static void Run()
    {
        Console.WriteLine("Question 10: Chocolates distribution");
        Console.Write("Enter number of chocolates: ");
        int chocolates = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter number of children: ");
        int children = Convert.ToInt32(Console.ReadLine());

        int[] result = Program.FindRemainderAndQuotient(chocolates, children);
        Console.WriteLine($"Each child gets {result[0]} chocolate(s) and {result[1]} remains");
    }
}
