using System;

class Employee
{
    public string EmployeeID;
    protected string Department;
    private double Salary;

    public Employee(string EmployeeID, string Department, double Salary)
    {
        this.EmployeeID = EmployeeID;
        this.Department = Department;
        this.Salary = Salary;
    }

    public double GetSalary() {return Salary;}

    private void SetSalary(double Salary){this.Salary = Salary;}

    public void Display()
    {
        Console.WriteLine($"Employee ID : {EmployeeID}");
        Console.WriteLine($"Department  : {Department}");
        Console.WriteLine($"Salary      : {Salary}");
    }
}

class Manager : Employee
{
    public Manager(string emp, string dept, double sal) : base(emp, dept, sal){}

    public void DisplayEmployeeID()
    {
        Console.WriteLine($"{EmployeeID} accessed from Manager class.");
    }

    public void DisplayDepartment()
    {
        Console.WriteLine($"{Department} accessed from Manager class.");
    }
}