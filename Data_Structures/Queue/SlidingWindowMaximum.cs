using System;
using System.Collections.Generic;

namespace QueueApp.Problems;

public static class SlidingWindowMaximum
{
    public static int[] FindMaximums(int[] numbers, int windowSize)
    {
        if (numbers == null || numbers.Length == 0 || windowSize <= 0 || windowSize > numbers.Length)
        {
            return Array.Empty<int>();
        }

        var deque = new List<int>();
        var result = new List<int>();

        for (var i = 0; i < numbers.Length; i++)
        {
            while (deque.Count > 0 && deque[0] <= i - windowSize)
            {
                deque.RemoveAt(0);
            }

            while (deque.Count > 0 && numbers[deque[deque.Count - 1]] <= numbers[i])
            {
                deque.RemoveAt(deque.Count - 1);
            }

            deque.Add(i);

            if (i >= windowSize - 1)
            {
                result.Add(numbers[deque[0]]);
            }
        }

        return result.ToArray();
    }
}
