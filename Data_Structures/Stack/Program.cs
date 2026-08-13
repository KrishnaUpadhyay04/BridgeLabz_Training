using System;
using System.Collections.Generic;
using System.Linq;
using StackApp.Problems;

namespace StackApp;

public static class Program
{
    public static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("=== Stack Problems Menu ===");
            Console.WriteLine("1. Implement Queue Using Stacks");
            Console.WriteLine("2. Sort a Stack Using Recursion");
            Console.WriteLine("3. Stock Span Problem");
            Console.WriteLine("0. Exit");
            Console.Write("Select an option: ");

            var choice = Console.ReadLine();
            Console.WriteLine();

            switch (choice)
            {
                case "1":
                    RunQueueUsingStacks();
                    break;
                case "2":
                    RunSortStackUsingRecursion();
                    break;
                case "3":
                    RunStockSpan();
                    break;
                case "0":
                    Console.WriteLine("Exiting Stack program.");
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

    private static void RunQueueUsingStacks()
    {
        Console.WriteLine("Implement Queue Using Stacks");
        Console.Write("Enter integer values to enqueue separated by spaces: ");
        var values = ReadIntArray();

        var queue = new QueueUsingStacks();
        foreach (var value in values)
        {
            queue.Enqueue(value);
        }

        Console.WriteLine($"Queue after enqueue: {queue}");

        Console.Write("Do you want to dequeue the queue? (y/n): ");
        var response = Console.ReadLine();
        if (string.Equals(response, "y", StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("Dequeued values:");
            while (queue.Count > 0)
            {
                Console.WriteLine($"- {queue.Dequeue()}");
            }
        }
    }

    private static void RunSortStackUsingRecursion()
    {
        Console.WriteLine("Sort a Stack Using Recursion");
        Console.Write("Enter integer values separated by spaces: ");
        var values = ReadIntArray();

        var stack = new Stack<int>();
        foreach (var value in values)
        {
            stack.Push(value);
        }

        Console.WriteLine($"Original stack: {DisplayStack(stack)}");
        SortStackUsingRecursion.Sort(stack);
        Console.WriteLine($"Sorted stack: {DisplayStack(stack)}");
    }

    private static void RunStockSpan()
    {
        Console.WriteLine("Stock Span Problem");
        Console.Write("Enter stock prices separated by spaces: ");
        var prices = ReadIntArray();

        var spans = StockSpanProblem.CalculateSpan(prices);
        Console.WriteLine($"Prices: {string.Join(", ", prices)}");
        Console.WriteLine($"Spans: {string.Join(", ", spans)}");
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

    private static string DisplayStack(Stack<int> stack)
    {
        var values = stack.ToArray();
        Array.Reverse(values);
        return values.Length == 0 ? "[]" : $"[{string.Join(", ", values)}]";
    }
}

