using System.Text.RegularExpressions;

public static class ValidateCsvData
{
    public static void Run(string path)
    {
        int row = 1;
        foreach (Dictionary<string, string> record in CsvUtilities.Read(path))
        {
            List<string> errors = new();
            if (!Regex.IsMatch(CsvUtilities.Get(record, "Email"), @"^[^\s@]+@[^\s@]+\.[^\s@]+$")) errors.Add("invalid email");
            if (!Regex.IsMatch(CsvUtilities.Get(record, "Phone", "Phone Number", "Phone Numbers"), @"^\d{10}$")) errors.Add("phone must contain exactly 10 digits");
            if (errors.Count > 0) Console.WriteLine($"Row {row}: {string.Join(", ", errors)}");
            row++;
        }
    }
}
