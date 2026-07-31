using System;

internal class Student
{
    public string RollNo;
    protected string Name;
    private double CGPA;

    public Student(string rollno, string name, double cgpa)
    {
        RollNo = rollno;
        Name = name;
        CGPA = cgpa;
    }

    public double GetCGPA() {return CGPA;}

    private void SetCGPA(double cgpa)
    {
        if(0 <= cgpa && cgpa <= 10) CGPA = cgpa;

        else Console.WriteLine("Invalid CGPA");
    }

    public void Display()
    {
        Console.WriteLine($"Roll Number : {RollNo}");
        Console.WriteLine($"Name        : {Name}");
        Console.WriteLine($"CGPA        : {CGPA}");
    }
}

class PostGraduateStudents : Student
{
    public string Specialization;

    public PostGraduateStudents(string rollno, string name, double cgpa, string specialization) : base(rollno, name, cgpa)
    {
        Specialization = specialization;
    }

    internal void DisplayPGStudent()
    {
        Console.WriteLine($"Roll Number    : {RollNo}");
        Console.WriteLine($"Name           : {Name}");
        Console.WriteLine($"CGPA           : {GetCGPA()}");
        Console.WriteLine($"Specialization : {Specialization}");
    }
}