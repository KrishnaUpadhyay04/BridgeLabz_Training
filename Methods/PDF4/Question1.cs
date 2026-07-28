using System;

public class Question1
{
    public static void Run()
    {
        Console.WriteLine("Question 1: Football team heights");
        int[] heights = Program.GenerateRandomHeights(11);
        Console.WriteLine("Heights:");
        foreach (int height in heights)
        {
            Console.Write(height + " ");
        }
        Console.WriteLine();

        int sum = Program.FindSum(heights);
        double mean = Program.FindMean(heights);
        int shortest = Program.FindShortest(heights);
        int tallest = Program.FindTallest(heights);

        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine($"Mean: {mean}");
        Console.WriteLine($"Shortest: {shortest}");
        Console.WriteLine($"Tallest: {tallest}");
    }
}
