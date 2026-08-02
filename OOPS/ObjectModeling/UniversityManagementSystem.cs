using System;
using System.Collections.Generic;

namespace ObjectModeling.UniversityMgmt
{
    class Student
    {
        public string Name { get; }

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
                course.AddStudent(this);
            }

            Console.WriteLine($"{Name} enrolled in {course.CourseName}");
        }

        public void DisplayCourses()
        {
            Console.WriteLine($"\n{Name}'s Courses:");

            foreach (Course course in courses)
            {
                Console.WriteLine(course.CourseName);
            }
        }
    }

    class Professor
    {
        public string Name { get; }

        private List<Course> courses = new();

        public Professor(string name)
        {
            Name = name;
        }

        public void AssignCourse(Course course)
        {
            if (!courses.Contains(course))
            {
                courses.Add(course);
                course.AssignProfessor(this);
            }

            Console.WriteLine($"{Name} is assigned to teach {course.CourseName}");
        }

        public void DisplayCourses()
        {
            Console.WriteLine($"\n{Name} teaches:");

            foreach (Course course in courses)
            {
                Console.WriteLine(course.CourseName);
            }
        }
    }

    class Course
    {
        public string CourseName { get; }

        private List<Student> students = new();

        private Professor professor;

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

        public void AssignProfessor(Professor professor)
        {
            this.professor = professor;
        }

        public void DisplayStudents()
        {
            Console.WriteLine($"\nStudents enrolled in {CourseName}:");

            foreach (Student student in students)
            {
                Console.WriteLine(student.Name);
            }
        }

        public void DisplayProfessor()
        {
            Console.WriteLine($"\nProfessor for {CourseName}:");

            if (professor != null)
                Console.WriteLine(professor.Name);
            else
                Console.WriteLine("No Professor Assigned");
        }
    }

    class University
    {
        public string Name { get; }

        private List<Student> students = new();
        private List<Professor> professors = new();
        private List<Course> courses = new();

        public University(string name)
        {
            Name = name;
        }

        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        public void AddProfessor(Professor professor)
        {
            professors.Add(professor);
        }

        public void AddCourse(Course course)
        {
            courses.Add(course);
        }

        public void DisplayStudents()
        {
            Console.WriteLine($"\nStudents in {Name}:");

            foreach (Student student in students)
            {
                Console.WriteLine(student.Name);
            }
        }

        public void DisplayProfessors()
        {
            Console.WriteLine($"\nProfessors in {Name}:");

            foreach (Professor professor in professors)
            {
                Console.WriteLine(professor.Name);
            }
        }

        public void DisplayCourses()
        {
            Console.WriteLine($"\nCourses in {Name}:");

            foreach (Course course in courses)
            {
                Console.WriteLine(course.CourseName);
            }
        }
    }
}