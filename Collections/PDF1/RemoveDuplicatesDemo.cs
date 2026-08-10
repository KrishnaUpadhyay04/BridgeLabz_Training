using System;
using System.Collections.Generic;

public static class RemoveDuplicatesDemo
{
    public static void Run()
    {
        Console.WriteLine("Enter integers separated by spaces (default: 3 1 2 2 3 4):");
        var line = Console.ReadLine();
        var list = ParseInts(line) ?? new List<int>{3,1,2,2,3,4};
        var outList = RemoveDuplicatesPreserveOrder(list);
        Console.WriteLine("Result: " + string.Join(", ", outList));
    }

    public static List<T> RemoveDuplicatesPreserveOrder<T>(IEnumerable<T> items)
    {
        var seen = new HashSet<T>();
        var res = new List<T>();
        foreach(var it in items)
        {
            if (!seen.Contains(it)) { seen.Add(it); res.Add(it); }
        }
        return res;
    }

    private static List<int>? ParseInts(string? s)
    {
        if (string.IsNullOrWhiteSpace(s)) return null;
        var parts = s.Split(new[]{' ',','}, StringSplitOptions.RemoveEmptyEntries);
        var res = new List<int>();
        foreach(var p in parts) if (int.TryParse(p, out var v)) res.Add(v);
        return res;
    }
}
