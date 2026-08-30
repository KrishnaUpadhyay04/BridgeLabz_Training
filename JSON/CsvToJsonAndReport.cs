using System.Text.Json;

public static class CsvToJsonAndReport
{
    public static void CsvToJson(string csvPath, string jsonPath)
    {
        string[] lines = File.ReadAllLines(csvPath);
        if (lines.Length == 0) return;
        string[] headers = lines[0].Split(',');
        List<Dictionary<string, string>> records = new();
        foreach (string line in lines.Skip(1).Where(line => !string.IsNullOrWhiteSpace(line)))
        {
            string[] values = line.Split(',');
            records.Add(headers.Select((header, index) => new { header, index }).ToDictionary(item => item.header, item => item.index < values.Length ? values[item.index] : string.Empty));
        }
        File.WriteAllText(jsonPath, JsonSerializer.Serialize(records, new JsonSerializerOptions { WriteIndented = true }));
    }

    public static void GenerateDatabaseReport(string outputPath)
    {
        var employees = new[]
        {
            new { EmployeeId = "E001", Name = "Asha", Department = "IT", Salary = 75000m },
            new { EmployeeId = "E002", Name = "Ravi", Department = "HR", Salary = 62000m }
        };
        File.WriteAllText(outputPath, JsonSerializer.Serialize(employees, new JsonSerializerOptions { WriteIndented = true }));
    }
}
