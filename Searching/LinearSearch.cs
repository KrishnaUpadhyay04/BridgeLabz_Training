namespace Searching;

public static class LinearSearch
{
    public static int FirstNegativeNumber(int[] nums)
    {
        ArgumentNullException.ThrowIfNull(nums);
        for (int index = 0; index < nums.Length; index++)
        {
            if (nums[index] < 0) return index;
        }

        return -1;
    }

    public static int FindSentenceContainingWord(string[] sentences, string word)
    {
        ArgumentNullException.ThrowIfNull(sentences);
        ArgumentNullException.ThrowIfNull(word);
        for (int index = 0; index < sentences.Length; index++)
        {
            if (sentences[index].Contains(word, StringComparison.OrdinalIgnoreCase)) return index;
        }

        return -1;
    }
}