using System;
using System.Collections.Generic;
using System.Linq;
using HashmapApp.Problems;

namespace HashmapApp;

public static class Program
{
    public static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("=== Hash Map Problems Menu ===");
            Console.WriteLine("1. Find All Subarrays with Zero Sum");
            Console.WriteLine("2. Check for a Pair with Given Sum in an Array");
            Console.WriteLine("3. Longest Consecutive Sequence");
            Console.WriteLine("4. Implement a Custom Hash Map");
            Console.WriteLine("5. Two Sum Problem");
            Console.WriteLine("0. Exit");
            Console.Write("Select an option: ");

            var choice = Console.ReadLine();
            Console.WriteLine();

            switch (choice)
            {
                case "1":
                    RunZeroSumSubarrays();
                    break;
                case "2":
                    RunPairWithGivenSum();
                    break;
                case "3":
                    RunLongestConsecutiveSequence();
                    break;
                case "4":
                    RunCustomHashMap();
                    break;
                case "5":
                    RunTwoSum();
                    break;
                case "0":
                    Console.WriteLine("Exiting Hashmap program.");
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

    private static void RunZeroSumSubarrays()
    {
        Console.WriteLine("Find All Subarrays with Zero Sum");
        Console.Write("Enter integer values separated by spaces: ");
        var numbers = ReadIntArray();

        var subarrays = ZeroSumSubarrays.FindAll(numbers);
        Console.WriteLine(subarrays.Count == 0
            ? "No zero-sum subarrays found."
            : $"Zero-sum subarrays: {string.Join(" | ", subarrays.Select(x => $"[{x.Start}, {x.End}]") )}");
    }

    private static void RunPairWithGivenSum()
    {
        Console.WriteLine("Check for a Pair with Given Sum in an Array");
        Console.Write("Enter integer values separated by spaces: ");
        var numbers = ReadIntArray();
        Console.Write("Enter target sum: ");
        var target = int.Parse(Console.ReadLine() ?? "0");

        var exists = PairWithGivenSum.Exists(numbers, target);
        Console.WriteLine(exists
            ? "A pair with the given sum exists."
            : "No pair with the given sum exists.");
    }

    private static void RunLongestConsecutiveSequence()
    {
        Console.WriteLine("Longest Consecutive Sequence");
        Console.Write("Enter integer values separated by spaces: ");
        var numbers = ReadIntArray();

        var length = LongestConsecutiveSequence.FindLength(numbers);
        Console.WriteLine($"Longest consecutive sequence length: {length}");
    }

    private static void RunCustomHashMap()
    {
        Console.WriteLine("Implement a Custom Hash Map");
        var map = new CustomHashMap<int, string>(10);
        Console.WriteLine("Add a few entries: 1->Alice, 2->Bob, 3->Charlie");
        map.Add(1, "Alice");
        map.Add(2, "Bob");
        map.Add(3, "Charlie");
        Console.WriteLine($"Get 2: {map.Get(2)}");
        Console.WriteLine($"Contains 3: {map.ContainsKey(3)}");
        Console.WriteLine("Remove 2");
        map.Remove(2);
        Console.WriteLine($"Contains 2 after removal: {map.ContainsKey(2)}");

        Console.Write("Would you like to add your own custom values? (y/n): ");
        var response = Console.ReadLine();
        if (string.Equals(response, "y", StringComparison.OrdinalIgnoreCase))
        {
            Console.Write("Enter key-value pairs as 'key:value' separated by spaces: ");
            var entries = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(entries))
            {
                foreach (var entryText in entries.Split(' ', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries))
                {
                    var parts = entryText.Split(':', 2, StringSplitOptions.TrimEntries);
                    if (parts.Length == 2 && int.TryParse(parts[0], out var key))
                    {
                        map.Add(key, parts[1]);
                    }
                }
            }
        }
    }

    private static void RunTwoSum()
    {
        Console.WriteLine("Two Sum Problem");
        Console.Write("Enter integer values separated by spaces: ");
        var numbers = ReadIntArray();
        Console.Write("Enter target sum: ");
        var target = int.Parse(Console.ReadLine() ?? "0");

        var indices = TwoSum.FindIndices(numbers, target);
        Console.WriteLine(indices is null
            ? "No valid pair found."
            : $"Pair found at indices [{indices[0]}, {indices[1]}].");
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
