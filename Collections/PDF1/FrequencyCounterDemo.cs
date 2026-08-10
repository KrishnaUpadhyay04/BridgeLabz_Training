using System;
using System.Collections.Generic;

public static class FrequencyCounterDemo
{
    public static void Run()
    {
        Console.WriteLine("Enter strings separated by commas (e.g. apple,banana,apple):");
        var line = Console.ReadLine() ?? "apple,banana,apple,orange";
        var parts = line.Split(new[]{',',' '}, StringSplitOptions.RemoveEmptyEntries);
        var dict = new Dictionary<string,int>(StringComparer.OrdinalIgnoreCase);
        foreach(var p in parts)
        {
            if (dict.ContainsKey(p)) dict[p]++; else dict[p]=1;
        }
        Console.WriteLine("Frequencies:");
        foreach(var kv in dict) Console.WriteLine($"{kv.Key}: {kv.Value}");
    }
}
