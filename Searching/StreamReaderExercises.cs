using System.Text;

namespace Searching;

public static class StreamReaderExercises
{
    public static List<string> ReadLines(string filePath)
    {
        List<string> lines = new();
        using StreamReader reader = new(filePath, Encoding.UTF8);
        while (reader.ReadLine() is { } line) lines.Add(line);
        return lines;
    }

    public static int CountWord(string filePath, string word)
    {
        ArgumentNullException.ThrowIfNull(word);
        int count = 0;
        using StreamReader reader = new(filePath, Encoding.UTF8);
        while (reader.ReadLine() is { } line)
        {
            string[] words = line.Split((char[]?)null, StringSplitOptions.RemoveEmptyEntries);
            foreach (string candidate in words)
            {
                if (string.Equals(candidate.TrimEnd('.', ',', '!', '?', ':', ';'), word,
                    StringComparison.OrdinalIgnoreCase)) count++;
            }
        }

        return count;
    }

    public static string ReadBytesAsCharacters(string filePath, Encoding? encoding = null)
    {
        using StreamReader reader = new(filePath, encoding ?? Encoding.UTF8);
        return reader.ReadToEnd();
    }

    public static void WriteInputToFile(StreamReader input, string filePath)
    {
        ArgumentNullException.ThrowIfNull(input);
        using StreamWriter writer = new(filePath, false, Encoding.UTF8);
        while (input.ReadLine() is { } line) writer.WriteLine(line);
    }
}
