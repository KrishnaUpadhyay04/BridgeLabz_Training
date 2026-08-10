using System;
using System.Collections.Generic;

public static class RotateListDemo
{
    public static void Run()
    {
        Console.WriteLine("Enter numbers separated by spaces (default: 10 20 30 40 50):");
        var line = Console.ReadLine();
        var list = ParseInts(line) ?? new List<int>{10,20,30,40,50};
        Console.Write("Rotate by positions: ");
        var kStr = Console.ReadLine();
        int k =  (int.TryParse(kStr, out var tv) ? tv : 2);
        var rotated = Rotate(list, k);
        Console.WriteLine("Result: " + string.Join(", ", rotated));
    }

    public static List<T> Rotate<T>(List<T> list, int k)
    {
        int n = list.Count;
        if (n==0) return new List<T>();
        k = ((k % n) + n) % n;
        var res = new List<T>(n);
        for (int i = k; i < k + n; i++) res.Add(list[i % n]);
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
