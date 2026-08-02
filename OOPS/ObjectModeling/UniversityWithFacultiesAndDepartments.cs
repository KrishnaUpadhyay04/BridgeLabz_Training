using System;
using System.Collections.Generic;

namespace ObjectModeling.UniversityFaculties
{
    class Faculty
    {
        public string Name { get; }

        public Faculty(string name)
        {
            Name = name;
        }

        public void Display()
        {
            Console.WriteLine($"Faculty: {Name}");
        }
    }

    class Department
    {
        public string DepartmentName { get; }

        public Department(string departmentName)
        {
            DepartmentName = departmentName;
        }

        public void Display()
        {
            Console.WriteLine($"Department: {DepartmentName}");
        }

        ~Department()
        {
            Console.WriteLine($"Department {DepartmentName} destroyed.");
        }
    }

    class University
    {
        public string UniversityName { get; }

        // Composition
        private List<Department> departments = new();

        // Aggregation
        private List<Faculty> faculties = new();

        public University(string universityName)
        {
            UniversityName = universityName;
        }

        public void AddDepartment(string departmentName)
        {
            // Composition:
            // University creates the Department itself.
            departments.Add(new Department(departmentName));
        }

        public void AddFaculty(Faculty faculty)
        {
            // Aggregation:
            // Faculty object is created outside.
            faculties.Add(faculty);
        }

        public void DisplayDepartments()
        {
            Console.WriteLine($"\nDepartments in {UniversityName}:");

            foreach (Department department in departments)
            {
                department.Display();
            }
        }

        public void DisplayFaculties()
        {
            Console.WriteLine($"\nFaculty Members:");

            foreach (Faculty faculty in faculties)
            {
                faculty.Display();
            }
        }

        ~University()
        {
            Console.WriteLine($"\nUniversity {UniversityName} destroyed.");
        }
    }
}