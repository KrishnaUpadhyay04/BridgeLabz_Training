using System;
using System.Collections.Generic;

public static class BankingSystemDemo
{
    public static void Run()
    {
        var balances = new Dictionary<int,double>{{101,500.0},{102,1200.5}};
        var withdrawals = new Queue<(int acct,double amt)>();
        withdrawals.Enqueue((101,100)); withdrawals.Enqueue((102,200));
        Console.WriteLine("Processing withdrawals:");
        while(withdrawals.Count>0)
        {
            var w = withdrawals.Dequeue();
            if (balances.ContainsKey(w.acct) && balances[w.acct] >= w.amt)
            {
                balances[w.acct] -= w.amt; Console.WriteLine($"Acct {w.acct} withdrawn {w.amt}");
            }
            else Console.WriteLine($"Acct {w.acct} insufficient funds");
        }
        Console.WriteLine("Balances:"); foreach(var kv in balances) Console.WriteLine($"{kv.Key}: {kv.Value}");
    }
}
