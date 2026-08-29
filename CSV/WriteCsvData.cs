public static class WriteCsvData
{
    public static void Run(string path)
    {
        string[] headers = { "ID", "Name", "Department", "Salary" };
        List<Dictionary<string, string>> records = new();
        for (int index = 1; index <= 5; index++)
        {
            Console.WriteLine($"Employee {index}");
            records.Add(new Dictionary<string, string>
            {
                ["ID"] = Read("ID: "), ["Name"] = Read("Name: "),
                ["Department"] = Read("Department: "), ["Salary"] = Read("Salary: ")
            });
        }
        CsvUtilities.Write(path, headers, records);
        Console.WriteLine($"Created {path}");
    }

    private static string Read(string prompt) { Console.Write(prompt); return Console.ReadLine() ?? string.Empty; }
}
