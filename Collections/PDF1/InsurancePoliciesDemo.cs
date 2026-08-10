using System;
using System.Collections.Generic;

public static class InsurancePoliciesDemo
{
    private static HashSet<string> policies = new HashSet<string>();
    public static void Run()
    {
        Console.WriteLine("1: Add policy ID, 2: Retrieve all policies");
        var op = Console.ReadLine();
        if (op=="1") { Console.Write("Policy ID: "); var id=Console.ReadLine(); if(!string.IsNullOrWhiteSpace(id)) policies.Add(id); Console.WriteLine("Added."); }
        else { Console.WriteLine("Policies: " + string.Join(", ", policies)); }
    }
}
