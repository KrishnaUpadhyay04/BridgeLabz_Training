using System;

public class Course
{
    public string CourseName;
    public string Duration;
    public double Fees {get; private set;}

    public static string InstitueName;

    public Course(string name, string time, double fees)
    {
        CourseName = name;
        Duration = time;
        Fees = fees;
    }

    public void DisplayCourseDetails()
    {
        Console.WriteLine($"Institute Name  : {InstitueName}");
        Console.WriteLine($"Course Name     : {CourseName}");
        Console.WriteLine($"Course Duration : {Duration}");
        Console.WriteLine($"Course Fee      : {Fees}");
    }

    public static void UpdateInstituteName(string name)
    {
        InstitueName = name;
        Console.WriteLine("Institute Name Updated Successfully!");
    }
}