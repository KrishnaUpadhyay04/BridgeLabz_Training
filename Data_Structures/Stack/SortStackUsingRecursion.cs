using System;
using System.Collections.Generic;

namespace StackApp.Problems;

public static class SortStackUsingRecursion
{
    public static void Sort(Stack<int> stack)
    {
        if (stack.Count <= 1)
        {
            return;
        }

        var top = stack.Pop();
        Sort(stack);
        InsertSorted(stack, top);
    }

    private static void InsertSorted(Stack<int> stack, int value)
    {
        if (stack.Count == 0 || stack.Peek() <= value)
        {
            stack.Push(value);
            return;
        }

        var temp = stack.Pop();
        InsertSorted(stack, value);
        stack.Push(temp);
    }
}
