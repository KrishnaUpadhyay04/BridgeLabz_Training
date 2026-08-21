namespace Searching;

public static class SearchChallenge
{
    public static int FirstMissingPositive(int[] numbers)
    {
        ArgumentNullException.ThrowIfNull(numbers);
        for (int candidate = 1; candidate <= numbers.Length + 1; candidate++)
        {
            bool found = false;
            foreach (int number in numbers)
            {
                if (number == candidate)
                {
                    found = true;
                    break;
                }
            }

            if (!found) return candidate;
        }

        return numbers.Length + 1;
    }

    public static int FindTargetIndex(int[] sortedNumbers, int target)
    {
        ArgumentNullException.ThrowIfNull(sortedNumbers);
        int start = 0, end = sortedNumbers.Length - 1;
        while (start <= end)
        {
            int middle = start + (end - start) / 2;
            if (sortedNumbers[middle] == target) return middle;
            if (sortedNumbers[middle] < target) start = middle + 1;
            else end = middle - 1;
        }

        return -1;
    }
}
