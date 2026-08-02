using System;
using System.Collections.Generic;

namespace ObjectModeling.Company
{
    class Employee
    {
        public string Name;
        public Department Department;
        public double Salary { get; internal set; }

        public Employee(string Name, Department Department, double Salary)
        {
            this.Name = Name;
            this.Department = Department;
            this.Salary = Salary;
        }

        public void DisplayEmployeeDetails()
        {
            Console.WriteLine($"Employee Name : {Name}");
            Console.WriteLine($"Department    : {Department.Name}");
            Console.WriteLine($"Salary        : {Salary}");
        }
    }

    class Department
    {
        public string Name;

        public List<Employee> Employees = new List<Employee>();

        public Department(string Name)
        {
            this.Name = Name;
            Employees = new List<Employee>();
        }

        public void AddEmployee(Employee employee)
        {
            Employees.Add(employee);
        }

        public void DisplayDepartmentDetails()
        {
            Console.WriteLine($"Department Name: {Name}");
            Console.WriteLine($"Total Employees: {Employees.Count}");
            Console.WriteLine("Employees in the Department:");
            Console.WriteLine("Total Employees: " + Employees.Count);
            foreach (var employee in Employees)
            {
                employee.DisplayEmployeeDetails();
                Console.WriteLine("------------------------");
            }
        }
    }

    class Company
    {
        public static string Name = "Chitkara Industeries";
        public static int TotalEmployees = 0;

        public List<Department> Departments;

        public Company()
        {
            Departments = new List<Department>();
        }

        public void AddDepartment(Department department)
        {
            Departments.Add(department);
        }

        public void DisplayCompanyDetails()
        {
            Console.WriteLine($"Company Name: {Name}");
            foreach (var department in Departments) TotalEmployees += department.Employees.Count;
            Console.WriteLine($"Total Employees: {TotalEmployees}");
            Console.WriteLine("Departments in the Company: ");
            foreach (var department in Departments)
            {
                department.DisplayDepartmentDetails();
                Console.WriteLine("------------------------");
            }

        }
    }
}