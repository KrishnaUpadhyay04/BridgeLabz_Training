using System;

class Student
{
    public static string UniversityName = "Chitkara University";
    public static int TotalStudents = 0;

    public readonly int RollNumber;
    public string Name;
    public char Grade;

    public Student(string Name, int RollNumber, char Grade)
    {
        this.Name = Name;
        this.RollNumber = RollNumber;
        this.Grade = Grade;
        TotalStudents++;
    }

    public static void DisplayTotalStudents()
    {
        Console.WriteLine($"Total Students: {TotalStudents}");
    }

    public void DisplayStudentDetails()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Roll Number: {RollNumber}");
        Console.WriteLine($"Grade: {Grade}");
    }

}