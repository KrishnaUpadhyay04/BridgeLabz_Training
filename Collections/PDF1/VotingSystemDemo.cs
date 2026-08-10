using System;
using System.Collections.Generic;
using System.Linq;

public static class VotingSystemDemo
{
    public static void Run()
    {
        var votes = new Dictionary<string,int>();
        Console.WriteLine("Enter votes one per line (blank to finish):");
        while(true)
        {
            var v = Console.ReadLine(); if (string.IsNullOrWhiteSpace(v)) break;
            votes[v] = votes.GetValueOrDefault(v,0)+1;
        }
        var sorted = new SortedDictionary<string,int>(votes);
        Console.WriteLine("Results (sorted):");
        foreach(var kv in sorted) Console.WriteLine($"{kv.Key}: {kv.Value}");
    }
}
