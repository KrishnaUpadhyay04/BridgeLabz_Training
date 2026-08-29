public static class FindDuplicateIds
{
    public static void Run(string path)
    {
        foreach (IGrouping<string, Dictionary<string, string>> group in CsvUtilities.Read(path)
            .GroupBy(record => CsvUtilities.Get(record, "ID", "Id"), StringComparer.OrdinalIgnoreCase)
            .Where(group => group.Key.Length > 0 && group.Count() > 1))
        {
            Console.WriteLine($"Duplicate ID: {group.Key}");
            foreach (Dictionary<string, string> record in group) Console.WriteLine($"  {string.Join(" | ", record.Values)}");
        }
    }
}
