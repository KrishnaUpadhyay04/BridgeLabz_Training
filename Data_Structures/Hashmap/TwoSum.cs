using System.Collections.Generic;

namespace HashmapApp.Problems;

public static class TwoSum
{
    public static int[]? FindIndices(int[] numbers, int target)
    {
        if (numbers == null || numbers.Length < 2)
        {
            return null;
        }

        var seen = new Dictionary<int, int>();

        for (var i = 0; i < numbers.Length; i++)
        {
            var remaining = target - numbers[i];
            if (seen.ContainsKey(remaining))
            {
                return new[] { seen[remaining], i };
            }

            if (!seen.ContainsKey(numbers[i]))
            {
                seen[numbers[i]] = i;
            }
        }

        return null;
    }
}
