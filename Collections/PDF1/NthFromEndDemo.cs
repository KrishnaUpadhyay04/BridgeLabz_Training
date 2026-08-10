using System;
using System.Collections.Generic;

public static class NthFromEndDemo
{
    public static void Run()
    {
        Console.WriteLine("Enter linked-list elements separated by spaces (default: A B C D E):");
        var line = Console.ReadLine();
        var parts = string.IsNullOrWhiteSpace(line) ? new List<string>{"A","B","C","D","E"} : new List<string>(line.Split(' ',StringSplitOptions.RemoveEmptyEntries));
        var list = new LinkedList<string>(parts);
        Console.Write("Enter N from end (default 2): ");
        var nStr = Console.ReadLine();
        int n = int.TryParse(nStr, out var tv) ? tv : 2;
        var val = NthFromEnd(list, n);
        Console.WriteLine(val is null ? "Not found" : $"{n}th from end: {val}");
    }

    public static T? NthFromEnd<T>(LinkedList<T> list, int n) where T : class
    {
        if (n <= 0) return default;
        var a = list.First;
        var b = list.First;
        for (int i=0;i<n;i++)
        {
            if (b==null) return default;
            b = b.Next;
        }
        while (b!=null)
        {
            a = a!.Next;
            b = b.Next;
        }
        return a?.Value;
    }
}
