using System;
using System.Collections.Generic;

public static class BinaryNumbersDemo
{
    public static void Run()
    {
        Console.Write("N: ");
        var nStr = Console.ReadLine();
        int n = int.TryParse(nStr, out var v)? v : 5;
        var res = GenerateBinary(n);
        Console.WriteLine(string.Join(", ", res));
    }

    public static List<string> GenerateBinary(int n)
    {
        var q = new Queue<string>();
        var result = new List<string>();
        if (n<=0) return result;
        q.Enqueue("1");
        while (result.Count < n)
        {
            var s = q.Dequeue();
            result.Add(s);
            q.Enqueue(s + "0");
            q.Enqueue(s + "1");
        }
        return result;
    }
}
