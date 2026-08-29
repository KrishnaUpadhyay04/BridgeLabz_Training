public static class MergeCsvFiles
{
    public static void Run(string firstPath, string secondPath, string outputPath)
    {
        List<Dictionary<string, string>> first = CsvUtilities.Read(firstPath);
        List<Dictionary<string, string>> second = CsvUtilities.Read(secondPath);
        string[] headers = first.SelectMany(record => record.Keys).Concat(second.SelectMany(record => record.Keys)).Distinct(StringComparer.OrdinalIgnoreCase).ToArray();
        Dictionary<string, Dictionary<string, string>> merged = new(StringComparer.OrdinalIgnoreCase);
        foreach (Dictionary<string, string> record in first.Concat(second))
        {
            string id = CsvUtilities.Get(record, "ID", "Id");
            if (id.Length == 0) continue;
            if (!merged.TryGetValue(id, out Dictionary<string, string>? target))
                merged[id] = target = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
            foreach ((string key, string value) in record) target[key] = value;
        }
        CsvUtilities.Write(outputPath, headers, merged.Values);
        Console.WriteLine($"Merged file: {outputPath}");
    }
}
