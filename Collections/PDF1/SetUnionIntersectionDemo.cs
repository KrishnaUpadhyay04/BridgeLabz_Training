using System;
using System.Collections.Generic;

public static class SetUnionIntersectionDemo
{
    public static void Run()
    {
        Console.WriteLine("Enter set1 elements:");
        var a = ReadInts();
        Console.WriteLine("Enter set2 elements:");
        var b = ReadInts();
        var sa = new HashSet<int>(a);
        var sb = new HashSet<int>(b);
        var union = new HashSet<int>(sa);
        union.UnionWith(sb);
        var inter = new HashSet<int>(sa);
        inter.IntersectWith(sb);
        Console.WriteLine("Union: " + string.Join(", ", union));
        Console.WriteLine("Intersection: " + string.Join(", ", inter));
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
