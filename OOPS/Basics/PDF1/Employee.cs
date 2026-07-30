using System;

class Employee
{
    private string name;
    private readonly int id;
    private double salary;

    public Employee(string name, int id, double salary)
    {
        this.name = name;
        this.id = id;
        this.salary = salary;
    }

    public void DisplayDetails()
    {
        Console.WriteLine("Employee Details");
        Console.WriteLine($"Employee Name   : {name}");
        Console.WriteLine($"Employee Id     : {id}");
        Console.WriteLine($"Employee Salary : {salary}");
    }
}