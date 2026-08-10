using System;
using System.Collections.Generic;
using System.Linq;

public static class InvertMapDemo
{
    public static void Run()
    {
        var dict = new Dictionary<string,int>{{"A",1},{"B",2},{"C",1}};
        Console.WriteLine("Original: A=1,B=2,C=1");
        var inv = new Dictionary<int,List<string>>();
        foreach(var kv in dict)
        {
            if (!inv.TryGetValue(kv.Value, out var list)) { list = new List<string>(); inv[kv.Value]=list; }
            list.Add(kv.Key);
        }
        foreach(var kv in inv) Console.WriteLine($"{kv.Key}=[{string.Join(",",kv.Value)}]");
    }
}
