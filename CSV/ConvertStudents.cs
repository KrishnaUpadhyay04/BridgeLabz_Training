public sealed class CsvStudent
{
    public string Id { get; init; } = string.Empty;
    public string Name { get; init; } = string.Empty;
    public int Age { get; init; }
    public decimal Marks { get; init; }
    public override string ToString() => $"{Id} | {Name} | Age: {Age} | Marks: {Marks}";
}

public static class ConvertStudents
{
    public static void Run(string path)
    {
        foreach (Dictionary<string, string> record in CsvUtilities.Read(path))
            Console.WriteLine(new CsvStudent
            {
                Id = CsvUtilities.Get(record, "ID", "Id"), Name = CsvUtilities.Get(record, "Name"),
                Age = int.TryParse(CsvUtilities.Get(record, "Age"), out int age) ? age : 0,
                Marks = CsvUtilities.Decimal(record, "Marks")
            });
    }
}
