using System;

class Employee
{
    public static string CompanyName = "Chitkara University";
    public static int TotalEmployees = 0;

    public readonly string EmployeeID;

    public string Name;
    public string Designation;

    public Employee(string Name, string Designation, string EmployeeID)
    {
        this.Name = Name;
        this.Designation = Designation;
        this.EmployeeID = EmployeeID;
    }

    public static void DisplayTotalEmployees()
    {
        Console.WriteLine($"Total Employees: {TotalEmployees}");
    }

    public void DisplayEmployeeDetails()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Designation: {Designation}");
        Console.WriteLine($"Employee ID: {EmployeeID}");
    }
}