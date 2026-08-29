public static class UpdateItSalaries
{
    public static void Run(string inputPath, string outputPath)
    {
        List<Dictionary<string, string>> records = CsvUtilities.Read(inputPath);
        foreach (Dictionary<string, string> record in records)
            if (string.Equals(CsvUtilities.Get(record, "Department"), "IT", StringComparison.OrdinalIgnoreCase))
                record[record.Keys.First(key => key.Equals("Salary", StringComparison.OrdinalIgnoreCase))] =
                    (CsvUtilities.Decimal(record, "Salary") * 1.10m).ToString("F2", System.Globalization.CultureInfo.InvariantCulture);
        CsvUtilities.Write(outputPath, records.FirstOrDefault()?.Keys.ToArray() ?? Array.Empty<string>(), records);
        Console.WriteLine($"Updated file: {outputPath}");
    }
}
