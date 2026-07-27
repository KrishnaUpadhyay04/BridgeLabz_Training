using System;

public class Question9
{
    public static void Run()
    {
        Console.WriteLine("Question 9: Quotient and remainder");
        Console.Write("Enter dividend: ");
        int number = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter divisor: ");
        int divisor = Convert.ToInt32(Console.ReadLine());

        int[] result = Program.FindRemainderAndQuotient(number, divisor);
        Console.WriteLine($"Quotient: {result[0]}, Remainder: {result[1]}");
    }
}
