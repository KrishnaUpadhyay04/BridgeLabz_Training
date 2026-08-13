using System;
using System.Linq;
using QueueApp.Problems;

namespace QueueApp;

public static class Program
{
    public static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("=== Queue Problems Menu ===");
            Console.WriteLine("1. Sliding Window Maximum");
            Console.WriteLine("2. Circular Tour Problem");
            Console.WriteLine("0. Exit");
            Console.Write("Select an option: ");

            var choice = Console.ReadLine();
            Console.WriteLine();

            switch (choice)
            {
                case "1":
                    RunSlidingWindowMaximum();
                    break;
                case "2":
                    RunCircularTour();
                    break;
                case "0":
                    Console.WriteLine("Exiting Queue program.");
                    return;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }

    private static void RunSlidingWindowMaximum()
    {
        Console.WriteLine("Sliding Window Maximum");
        Console.Write("Enter integer values separated by spaces: ");
        var numbers = ReadIntArray();
        Console.Write("Enter window size k: ");

        var kInput = Console.ReadLine();
        if (!int.TryParse(kInput, out var k) || k <= 0)
        {
            Console.WriteLine("Please enter a valid positive window size.");
            return;
        }

        var result = SlidingWindowMaximum.FindMaximums(numbers, k);
        Console.WriteLine($"Input: {string.Join(", ", numbers)}");
        Console.WriteLine($"Window size: {k}");
        Console.WriteLine($"Maximums: {string.Join(", ", result)}");
    }

    private static void RunCircularTour()
    {
        Console.WriteLine("Circular Tour Problem");
        Console.Write("Enter petrol values separated by spaces: ");
        var petrol = ReadIntArray();
        Console.Write("Enter distance values separated by spaces: ");
        var distance = ReadIntArray();

        if (petrol.Length != distance.Length)
        {
            Console.WriteLine("Petrol and distance arrays must have the same length.");
            return;
        }

        var start = CircularTourProblem.FindStartingPump(petrol, distance);
        Console.WriteLine(start == -1
            ? "No valid starting pump exists for a complete circular tour."
            : $"Starting pump index: {start}");
    }

    private static int[] ReadIntArray()
    {
        var input = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(input))
        {
            return Array.Empty<int>();
        }

        return input
            .Split(' ', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries)
            .Select(int.Parse)
            .ToArray();
    }
}
