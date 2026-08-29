using System.Text.Json;

public static class JsonCsvConversion
{
    public static void JsonToCsv(string jsonPath, string csvPath)
    {
        List<CsvStudent> students = JsonSerializer.Deserialize<List<CsvStudent>>(File.ReadAllText(jsonPath)) ?? new();
        CsvUtilities.Write(csvPath, new[] { "ID", "Name", "Age", "Marks" }, students.Select(student =>
            (IDictionary<string, string>)new Dictionary<string, string>
            {
                ["ID"] = student.Id, ["Name"] = student.Name, ["Age"] = student.Age.ToString(), ["Marks"] = student.Marks.ToString(System.Globalization.CultureInfo.InvariantCulture)
            }));
    }

    public static void CsvToJson(string csvPath, string jsonPath)
    {
        List<CsvStudent> students = CsvUtilities.Read(csvPath).Select(record => new CsvStudent
        {
            Id = CsvUtilities.Get(record, "ID", "Id"), Name = CsvUtilities.Get(record, "Name"),
            Age = int.TryParse(CsvUtilities.Get(record, "Age"), out int age) ? age : 0, Marks = CsvUtilities.Decimal(record, "Marks")
        }).ToList();
        File.WriteAllText(jsonPath, JsonSerializer.Serialize(students, new JsonSerializerOptions { WriteIndented = true }));
    }

    public static void Run(string jsonPath, string csvPath, string outputJsonPath)
    {
        JsonToCsv(jsonPath, csvPath); CsvToJson(csvPath, outputJsonPath);
        Console.WriteLine($"Created {csvPath} and {outputJsonPath}");
    }
}
