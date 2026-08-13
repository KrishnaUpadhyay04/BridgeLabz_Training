using System.Collections.Generic;

namespace HashmapApp.Problems;

public static class LongestConsecutiveSequence
{
    public static int FindLength(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
        {
            return 0;
        }

        var set = new HashSet<int>(numbers);
        var longest = 0;

        foreach (var number in numbers)
        {
            if (!set.Contains(number - 1))
            {
                var current = 1;
                while (set.Contains(number + current))
                {
                    current++;
                }

                if (current > longest)
                {
                    longest = current;
                }
            }
        }

        return longest;
    }
}
