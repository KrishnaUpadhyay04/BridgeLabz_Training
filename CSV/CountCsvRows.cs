public static class CountCsvRows
{
    public static void Run(string path) => Console.WriteLine($"Records: {CsvUtilities.Read(path).Count}");
}
