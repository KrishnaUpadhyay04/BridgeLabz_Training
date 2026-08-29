public static class ReadCsvData
{
    public static void Run(string path)
    {
        foreach (Dictionary<string, string> record in CsvUtilities.Read(path))
            Console.WriteLine(string.Join(" | ", record.Select(item => $"{item.Key}: {item.Value}")));
    }
}
