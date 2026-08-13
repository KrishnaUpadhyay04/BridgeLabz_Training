using System;
using System.Collections.Generic;
using System.Text;

namespace StackApp.Problems;

public class QueueUsingStacks
{
    private readonly Stack<int> enqueueStack;
    private readonly Stack<int> dequeueStack;

    public QueueUsingStacks()
    {
        enqueueStack = new Stack<int>();
        dequeueStack = new Stack<int>();
    }

    public int Count => enqueueStack.Count + dequeueStack.Count;

    public void Enqueue(int value)
    {
        enqueueStack.Push(value);
    }

    public int Dequeue()
    {
        if (Count == 0)
        {
            throw new InvalidOperationException("Queue is empty.");
        }

        if (dequeueStack.Count == 0)
        {
            while (enqueueStack.Count > 0)
            {
                dequeueStack.Push(enqueueStack.Pop());
            }
        }

        return dequeueStack.Pop();
    }

    public int Peek()
    {
        if (Count == 0)
        {
            throw new InvalidOperationException("Queue is empty.");
        }

        if (dequeueStack.Count == 0)
        {
            while (enqueueStack.Count > 0)
            {
                dequeueStack.Push(enqueueStack.Pop());
            }
        }

        return dequeueStack.Peek();
    }

    public override string ToString()
    {
        var values = new List<int>();
        var temp = new Stack<int>(dequeueStack);
        var tempEnqueue = new Stack<int>(enqueueStack);

        while (temp.Count > 0)
        {
            values.Add(temp.Pop());
        }

        while (tempEnqueue.Count > 0)
        {
            values.Add(tempEnqueue.Pop());
        }

        values.Reverse();

        var builder = new StringBuilder();
        builder.Append("[");
        for (var i = 0; i < values.Count; i++)
        {
            if (i > 0)
            {
                builder.Append(", ");
            }

            builder.Append(values[i]);
        }

        builder.Append("]");
        return builder.ToString();
    }
}
