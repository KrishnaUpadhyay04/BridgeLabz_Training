using System.Globalization;
using System.Text;

public static class CsvUtilities
{
    public static List<Dictionary<string, string>> Read(string path)
    {
        using StreamReader reader = new(path);
        string? headerLine = reader.ReadLine();
        if (string.IsNullOrWhiteSpace(headerLine)) return new();

        string[] headers = ParseLine(headerLine).ToArray();
        List<Dictionary<string, string>> records = new();
        string? line;
        while ((line = reader.ReadLine()) is not null)
        {
            if (string.IsNullOrWhiteSpace(line)) continue;
            string[] values = ParseLine(line).ToArray();
            Dictionary<string, string> record = new(StringComparer.OrdinalIgnoreCase);
            for (int index = 0; index < headers.Length; index++)
                record[headers[index]] = index < values.Length ? values[index] : string.Empty;
            records.Add(record);
        }
        return records;
    }

    public static void Write(string path, IEnumerable<string> headers, IEnumerable<IDictionary<string, string>> records)
    {
        using StreamWriter writer = new(path, false, new UTF8Encoding(false));
        string[] headerArray = headers.ToArray();
        writer.WriteLine(string.Join(',', headerArray.Select(Escape)));
        foreach (IDictionary<string, string> record in records)
            writer.WriteLine(string.Join(',', headerArray.Select(header => Escape(record.TryGetValue(header, out string? value) ? value : string.Empty))));
    }

    public static IEnumerable<string> ParseLine(string line)
    {
        StringBuilder value = new();
        bool quoted = false;
        for (int index = 0; index < line.Length; index++)
        {
            char character = line[index];
            if (character == '"')
            {
                if (quoted && index + 1 < line.Length && line[index + 1] == '"')
                {
                    value.Append('"');
                    index++;
                }
                else quoted = !quoted;
            }
            else if (character == ',' && !quoted)
            {
                yield return value.ToString();
                value.Clear();
            }
            else value.Append(character);
        }
        yield return value.ToString();
    }

    public static string Escape(string value)
    {
        return value.Contains(',') || value.Contains('"') || value.Contains('\n') || value.Contains('\r')
            ? $"\"{value.Replace("\"", "\"\"")}\""
            : value;
    }

    public static string Get(IDictionary<string, string> record, params string[] names)
    {
        foreach (string name in names)
            if (record.TryGetValue(name, out string? value)) return value;
        return string.Empty;
    }

    public static decimal Decimal(IDictionary<string, string> record, params string[] names)
    {
        return decimal.TryParse(Get(record, names), NumberStyles.Any, CultureInfo.InvariantCulture, out decimal value) ? value : 0;
    }
}
