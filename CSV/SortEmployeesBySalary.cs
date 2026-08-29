public static class SortEmployeesBySalary
{
    public static void Run(string path, int count)
    {
        foreach (Dictionary<string, string> record in CsvUtilities.Read(path).OrderByDescending(record => CsvUtilities.Decimal(record, "Salary")).Take(count))
            Console.WriteLine(string.Join(" | ", record.Values));
    }
}
