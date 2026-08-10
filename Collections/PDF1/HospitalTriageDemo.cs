using System;
using System.Collections.Generic;

public static class HospitalTriageDemo
{
    public static void Run()
    {
        var patients = new List<(string name,int severity)>{ ("John",3),("Alice",5),("Bob",2)};
        var pq = new PriorityQueue<string,int>();
        foreach(var p in patients) pq.Enqueue(p.name, -p.severity); // negative because lower priority first
        Console.WriteLine("Treatment order:");
        while(pq.Count>0) Console.WriteLine(pq.Dequeue());
    }
}
