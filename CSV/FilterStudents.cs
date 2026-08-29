public static class FilterStudents
{
    public static void Run(string path, decimal minimumMarks)
    {
        foreach (Dictionary<string, string> record in CsvUtilities.Read(path))
            if (CsvUtilities.Decimal(record, "Marks", "Score") > minimumMarks)
                Console.WriteLine(string.Join(" | ", record.Values));
    }
}
