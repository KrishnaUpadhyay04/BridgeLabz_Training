using System;
using System.Collections.Generic;
using System.Linq;

public static class SetToSortedListDemo
{
    public static void Run()
    {
        Console.WriteLine("Enter integers for set (e.g. 5 3 9 1):");
        var nums = ReadInts();
        var set = new HashSet<int>(nums);
        var sorted = set.OrderBy(x=>x).ToList();
        Console.WriteLine("Sorted list: " + string.Join(", ", sorted));
    }

    private static List<int> ReadInts()
    {
        var line = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(line)) return new List<int>{5,3,9,1};
        var parts = line.Split(' ',StringSplitOptions.RemoveEmptyEntries);
        var res = new List<int>();
        foreach(var p in parts) if (int.TryParse(p,out var v)) res.Add(v);
        return res;
    }
}
