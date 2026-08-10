using System;
using System.Collections.Generic;

public static class SymmetricDifferenceDemo
{
    public static void Run()
    {
        Console.WriteLine("Enter set A:");
        var a = ReadInts();
        Console.WriteLine("Enter set B:");
        var b = ReadInts();
        var sa = new HashSet<int>(a);
        var sb = new HashSet<int>(b);
        var res = new HashSet<int>(sa);
        res.SymmetricExceptWith(sb);
        Console.WriteLine("Symmetric Difference: " + string.Join(", ", res));
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
