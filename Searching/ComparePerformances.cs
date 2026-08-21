using System.Text;
using System.Diagnostics;

namespace Searching;

public static class Performance
{
    public static (long StringBuilderMilliseconds, long StringMilliseconds) Compare(List<string> words)
    {
        ArgumentNullException.ThrowIfNull(words);
        Stopwatch stopwatch = new();
        StringBuilder builder = new();
        stopwatch.Start();
        foreach (string word in words) builder.Append(word);
        stopwatch.Stop();
        long builderMilliseconds = stopwatch.ElapsedMilliseconds;

        string result = string.Empty;
        stopwatch.Restart();
        foreach (string word in words) result += word;
        stopwatch.Stop();

        return (builderMilliseconds, stopwatch.ElapsedMilliseconds);
    }
}
