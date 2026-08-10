using System;
using System.Collections.Generic;

public static class SetEqualityDemo
{
    public static void Run()
    {
        Console.WriteLine("Enter first set elements separated by spaces (e.g. 1 2 3):");
        var a = ReadInts();
        Console.WriteLine("Enter second set elements:");
        var b = ReadInts();
        var sa = new HashSet<int>(a);
        var sb = new HashSet<int>(b);
        Console.WriteLine(sa.SetEquals(sb));
    }

    private static List<int> ReadInts()
    {
        var line = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(line)) return new List<int>{1,2,3};
        var parts = line.Split(' ',StringSplitOptions.RemoveEmptyEntries);
        var res = new List<int>();
        foreach(var p in parts) if (int.TryParse(p,out var v)) res.Add(v);
        return res;
    }
}
