using System;
using System.Collections.Generic;

public static class ReverseQueueDemo
{
    public static void Run()
    {
        var q = new Queue<int>(new[]{10,20,30});
        Console.WriteLine("Input: " + string.Join(", ", q));
        var rev = ReverseQueue(q);
        Console.WriteLine("Reversed: " + string.Join(", ", rev));
    }

    // Using only queue operations via helper queue and stack simulation
    public static Queue<T> ReverseQueue<T>(Queue<T> q)
    {
        var stack = new Stack<T>();
        while (q.Count>0) stack.Push(q.Dequeue());
        while (stack.Count>0) q.Enqueue(stack.Pop());
        return q;
    }
}
