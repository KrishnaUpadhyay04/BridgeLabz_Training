using System.Text;
using System.Collections.Generic;

namespace Searching;

public static class RemoveDuplicates
{
    public static string RemoveDuplicate(string input)
    {
        ArgumentNullException.ThrowIfNull(input);
        StringBuilder result = new(input.Length);
        HashSet<char> seen = new();

        foreach (char character in input)
        {
            if (seen.Add(character)) result.Append(character);
        }

        return result.ToString();
    }
}