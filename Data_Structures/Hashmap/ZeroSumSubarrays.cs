using System;
using System.Collections.Generic;

namespace HashmapApp.Problems;

public record ZeroSumSubarray(int Start, int End);

public static class ZeroSumSubarrays
{
    public static List<ZeroSumSubarray> FindAll(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
        {
            return new List<ZeroSumSubarray>();
        }

        var result = new List<ZeroSumSubarray>();
        var prefixMap = new Dictionary<int, List<int>>
        {
            [0] = new List<int> { -1 }
        };

        var prefixSum = 0;

        for (var i = 0; i < numbers.Length; i++)
        {
            prefixSum += numbers[i];

            if (!prefixMap.ContainsKey(prefixSum))
            {
                prefixMap[prefixSum] = new List<int>();
            }

            if (prefixMap.TryGetValue(prefixSum, out var previousIndices))
            {
                foreach (var previousIndex in previousIndices)
                {
                    result.Add(new ZeroSumSubarray(previousIndex + 1, i));
                }
            }

            prefixMap[prefixSum].Add(i);
        }

        return result;
    }
}
