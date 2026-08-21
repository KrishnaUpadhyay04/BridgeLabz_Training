using System.Text;

namespace Searching;

public static class ReverseTheString
{
    public static string Reverse(string input)
    {
        ArgumentNullException.ThrowIfNull(input);
        StringBuilder result = new(input.Length);
        for (int index = input.Length - 1; index >= 0; index--)
        {
            result.Append(input[index]);
        }

        return result.ToString();
    }
}