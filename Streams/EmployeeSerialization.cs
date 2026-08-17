using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public string Department { get; set; } = "";
    public double Salary { get; set; }
}

public class EmployeeSerialization
{
    public void Execute()
    {
        string file = "employees.json";

        try
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee
                {
                    Id = 1,
                    Name = "Krishna",
                    Department = "IT",
                    Salary = 50000
                },

                new Employee
                {
                    Id = 2,
                    Name = "Rahul",
                    Department = "HR",
                    Salary = 45000
                },

                new Employee
                {
                    Id = 3,
                    Name = "Aman",
                    Department = "Finance",
                    Salary = 60000
                }
            };

            // Serialization
            string json = JsonSerializer.Serialize(
                employees,
                new JsonSerializerOptions
                {
                    WriteIndented = true
                }
            );

            File.WriteAllText(file, json);

            Console.WriteLine("Employees serialized successfully.");

            // Deserialization
            string storedJson = File.ReadAllText(file);

            List<Employee>? retrievedEmployees =
                JsonSerializer.Deserialize<List<Employee>>(storedJson);

            Console.WriteLine("\nRetrieved Employees:");

            if (retrievedEmployees != null)
            {
                foreach (Employee employee in retrievedEmployees)
                {
                    Console.WriteLine(
                        $"ID: {employee.Id}, " +
                        $"Name: {employee.Name}, " +
                        $"Department: {employee.Department}, " +
                        $"Salary: {employee.Salary}"
                    );
                }
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine("File error: " + ex.Message);
        }
        catch (JsonException ex)
        {
            Console.WriteLine("JSON error: " + ex.Message);
        }
    }
}