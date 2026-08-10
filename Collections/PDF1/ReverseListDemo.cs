using System;
using System.Collections.Generic;

public static class ReverseListDemo
{
    public static void Run()
    {
        Console.WriteLine("Reverse ArrayList example (using List<int>):");
        var arr = new List<int> {1,2,3,4,5};
        Console.WriteLine("Input: " + string.Join(", ", arr));
        var rev = ReverseList(arr);
        Console.WriteLine("Reversed: " + string.Join(", ", rev));

        Console.WriteLine("\nReverse LinkedList example:");
        var linked = new LinkedList<int>(new []{1,2,3,4,5});
        Console.WriteLine("Input: " + string.Join(", ", linked));
        var revLinked = ReverseLinkedList(linked);
        Console.WriteLine("Reversed: " + string.Join(", ", revLinked));
    }

    public static List<T> ReverseList<T>(List<T> input)
    {
        var result = new List<T>(input.Count);
        for (int i = input.Count - 1; i >= 0; i--) result.Add(input[i]);
        return result;
    }

    public static List<T> ReverseLinkedList<T>(LinkedList<T> list)
    {
        var res = new List<T>(list.Count);
        var node = list.Last;
        while (node != null)
        {
            res.Add(node.Value);
            node = node.Previous;
        }
        return res;
    }
}
