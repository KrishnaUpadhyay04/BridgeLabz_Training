using System;
using System.Collections.Generic;

namespace StackApp.Problems;

public static class StockSpanProblem
{
    public static int[] CalculateSpan(int[] prices)
    {
        if (prices == null || prices.Length == 0)
        {
            return Array.Empty<int>();
        }

        var spans = new int[prices.Length];
        var stack = new Stack<int>();

        for (var i = 0; i < prices.Length; i++)
        {
            while (stack.Count > 0 && prices[stack.Peek()] <= prices[i])
            {
                stack.Pop();
            }

            spans[i] = stack.Count == 0 ? i + 1 : i - stack.Peek();
            stack.Push(i);
        }

        return spans;
    }
}
