using System;

public class Question12
{
    public static void Run()
    {
        Console.WriteLine("Question 12: Random 4-digit numbers");
        Console.Write("Enter array size: ");
        int size = Convert.ToInt32(Console.ReadLine());

        int[] randomNumbers = Program.Generate4DigitRandomArray(size);
        Console.WriteLine("Generated numbers:");
        foreach (int number in randomNumbers)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();

        double[] stats = Program.FindAverageMinMax(randomNumbers);
        Console.WriteLine($"Average: {stats[0]}");
        Console.WriteLine($"Minimum: {stats[1]}");
        Console.WriteLine($"Maximum: {stats[2]}");
    }
}
