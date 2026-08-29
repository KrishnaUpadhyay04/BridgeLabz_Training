public static class SearchEmployee
{
    public static void Run(string path, string name)
    {
        Dictionary<string, string>? record = CsvUtilities.Read(path).FirstOrDefault(item =>
            string.Equals(CsvUtilities.Get(item, "Name"), name, StringComparison.OrdinalIgnoreCase));
        Console.WriteLine(record is null ? "Employee not found." : $"Department: {CsvUtilities.Get(record, "Department")}; Salary: {CsvUtilities.Get(record, "Salary")}");
    }
}
