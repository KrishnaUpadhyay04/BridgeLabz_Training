using System.Text;

namespace Searching;

public static class Concatenate
{
    public static string ConcatenateStrings(string[] words)
    {
        ArgumentNullException.ThrowIfNull(words);
        int capacity = 0;
        foreach (string word in words) capacity += word?.Length ?? 0;
        StringBuilder result = new(capacity);

        foreach (string? word in words)
        {
            result.Append(word);
        }

        return result.ToString();
    }
}