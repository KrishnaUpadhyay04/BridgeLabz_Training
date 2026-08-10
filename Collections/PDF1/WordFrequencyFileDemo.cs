using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public static class WordFrequencyFileDemo
{
    public static void Run()
    {
        Console.WriteLine("Enter text (or press enter to use sample):");
        var text = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(text)) text = "Hello world, hello Java!";
        var words = text.ToLowerInvariant().Split(new[]{' ',',','!','.','?',';',':','"','\''}, StringSplitOptions.RemoveEmptyEntries);
        var dict = new Dictionary<string,int>();
        foreach(var w in words) dict[w] = dict.GetValueOrDefault(w,0)+1;
        foreach(var kv in dict.OrderByDescending(k=>k.Value)) Console.WriteLine($"{kv.Key}: {kv.Value}");
    }
}
