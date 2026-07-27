using System;

public class Question8
{
    public static void Run()
    {
        Console.WriteLine("Question 8: Smallest and Largest of three numbers");
        Console.Write("Enter first number: ");
        int first = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        int second = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter third number: ");
        int third = Convert.ToInt32(Console.ReadLine());

        int[] result = Program.FindSmallestAndLargest(first, second, third);
        Console.WriteLine($"Smallest: {result[0]}, Largest: {result[1]}");
    }
}
