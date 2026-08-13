using System.Collections.Generic;

namespace HashmapApp.Problems;

public static class PairWithGivenSum
{
    public static bool Exists(int[] numbers, int target)
    {
        if (numbers == null || numbers.Length == 0)
        {
            return false;
        }

        var seen = new HashSet<int>();

        foreach (var number in numbers)
        {
            if (seen.Contains(target - number))
            {
                return true;
            }

            seen.Add(number);
        }

        return false;
    }
}
