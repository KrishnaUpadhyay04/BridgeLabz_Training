using System;
using System.Collections.Generic;

public abstract class CourseType
{
    public string EvaluationName { get; set; }

    protected CourseType(string evaluationName)
    {
        EvaluationName = evaluationName;
    }

    public abstract void Evaluate();
}

public class ExamCourse : CourseType
{
    public ExamCourse()
        : base("Final Examination")
    {
    }

    public override void Evaluate()
    {
        Console.WriteLine(
            "Evaluation: Students are evaluated through an examination."
        );
    }
}

public class AssignmentCourse : CourseType
{
    public AssignmentCourse()
        : base("Assignments")
    {
    }

    public override void Evaluate()
    {
        Console.WriteLine(
            "Evaluation: Students are evaluated through assignments."
        );
    }
}

public abstract class Course
{
    public string CourseCode { get; set; }
    public string CourseName { get; set; }
    public string Department { get; set; }

    public abstract void DisplayCourse();
}


public class Course<T> : Course
    where T : CourseType
{
    public T EvaluationType { get; set; }

    public Course(
        string courseCode,
        string courseName,
        string department,
        T evaluationType)
    {
        CourseCode = courseCode;
        CourseName = courseName;
        Department = department;
        EvaluationType = evaluationType;
    }

    public override void DisplayCourse()
    {
        Console.WriteLine($"Course Code : {CourseCode}");
        Console.WriteLine($"Course Name : {CourseName}");
        Console.WriteLine($"Department  : {Department}");
        Console.WriteLine($"Evaluation  : {EvaluationType.EvaluationName}");

        EvaluationType.Evaluate();

        Console.WriteLine("----------------------------");
    }
}
