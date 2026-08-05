using System;
using System.Collections.Generic;

namespace EmployeeManagementSystem
{
    interface IDepartment
    {
        void AssignDepartment(string department);

        string GetDepartmentDetails();
    }

    abstract class Employee
    {
        public string EmployeeId { get; private set; }
        public string Name { get; private set; }
        public double Salary { get; private set; }

        public Employee()
        {
            EmployeeId = "";
            Name = "Unknown";
            Salary = 0.0;
        }

        public Employee(string EmployeeId, string Name, double Salary)
        {
            this.EmployeeId = EmployeeId;
            this.Name = Name;
            this.Salary = Salary;
        }

        public abstract void CalculateSalary();

        public void DisplayDetails()
        {
            Console.WriteLine($"Employee Id : {EmployeeId}");
            Console.WriteLine($"Name        : {Name}");
            Console.WriteLine($"Salary      : {Salary}");
        }
    }

    class FullTimeEmployee : Employee, IDepartment
    {
        public string Department;

        public FullTimeEmployee() : base()
        {
            Department = "Unknown";
        }

        public FullTimeEmployee(string EmployeeId, string Name, double Salary, string Department) : base(EmployeeId, Name, Salary)
        {
            this.Department = Department;
        }

        public void DisplayFullTimeEmployeeDetails()
        {
            DisplayDetails();
            Console.WriteLine(GetDepartmentDetails());
        }

        public override void CalculateSalary()
        {
            Console.WriteLine($"Salary: {Salary}");
        }

        public void AssignDepartment(string Department)
        {
            this.Department = Department;
        }

        public string GetDepartmentDetails()
        {
            return $"Department: {Department}";
        }
    }

    class PartTimeEmployee : Employee, IDepartment
    {
        public string Department { get; private set; }
        public int WorkingHours { get; private set; }

        public PartTimeEmployee() : base()
        {
            Department = "Unknown";
            WorkingHours = 0;
        }

        public PartTimeEmployee(string EmployeeId, string Name, double Salary, string Department, int WorkingHours) : base(EmployeeId, Name, Salary)
        {
            this.Department = Department;
            this.WorkingHours = WorkingHours;
        }

        public override void CalculateSalary()
        {
            Console.WriteLine($"Salary for working {WorkingHours} hours: {Salary * WorkingHours}");
        }

        public void AssignDepartment(string Department)
        {
            this.Department = Department;
        }

        public string GetDepartmentDetails()
        {
            return $"Department: {Department}";
        }
    }
}
