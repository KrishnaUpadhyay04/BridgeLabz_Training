public sealed record DatabaseEmployee(string Id, string Name, string Department, decimal Salary);

public interface IEmployeeDataSource
{
    IEnumerable<DatabaseEmployee> GetEmployees();
}

public sealed class InMemoryEmployeeDataSource : IEmployeeDataSource
{
    public IEnumerable<DatabaseEmployee> GetEmployees() => new[]
    {
        new DatabaseEmployee("E001", "Asha", "IT", 75000),
        new DatabaseEmployee("E002", "Ravi", "HR", 62000)
    };
}

public static class DatabaseCsvReport
{
    public static void Run(string outputPath, IEmployeeDataSource source = null!)
    {
        source ??= new InMemoryEmployeeDataSource();
        CsvUtilities.Write(outputPath, new[] { "Employee ID", "Name", "Department", "Salary" }, source.GetEmployees().Select(employee =>
            (IDictionary<string, string>)new Dictionary<string, string>
            {
                ["Employee ID"] = employee.Id, ["Name"] = employee.Name,
                ["Department"] = employee.Department, ["Salary"] = employee.Salary.ToString("F2")
            }));
        Console.WriteLine($"Database report: {outputPath}");
    }
}
