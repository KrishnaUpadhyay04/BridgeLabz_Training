using System;
using System.Collections.Generic;

namespace ObjectModeling.School
{
    class School
    {
        public string Name { get; }
        private List<Student> students = new();

        public School(string name)
        {
            Name = name;
        }

        // Aggregation
        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        public void ShowStudents()
        {
            Console.WriteLine($"\nStudents in {Name}:");

            foreach (Student student in students)
            {
                Console.WriteLine(student.Name);
            }
        }
    }

    class Student
    {
        public string Name { get; }

        // Association
        private List<Course> courses = new();

        public Student(string name)
        {
            Name = name;
        }

        public void EnrollCourse(Course course)
        {
            if (!courses.Contains(course))
            {
                courses.Add(course);
                course.AddStudent(this);    // Maintain association from both sides
            }
        }

        public void ViewCourses()
        {
            Console.WriteLine($"\n{Name}'s Courses:");

            foreach (Course course in courses)
            {
                Console.WriteLine(course.CourseName);
            }
        }
    }

    class Course
    {
        public string CourseName { get; }

        // Association
        private List<Student> students = new();

        public Course(string courseName)
        {
            CourseName = courseName;
        }

        public void AddStudent(Student student)
        {
            if (!students.Contains(student))
            {
                students.Add(student);
            }
        }

        public void ShowStudents()
        {
            Console.WriteLine($"\nStudents enrolled in {CourseName}:");

            foreach (Student student in students)
            {
                Console.WriteLine(student.Name);
            }
        }
    }
}