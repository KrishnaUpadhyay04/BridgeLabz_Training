using System;
using System.Collections.Generic;

public abstract class JobRole
{
    public string RoleName { get; set; }

    protected JobRole(string roleName)
    {
        RoleName = roleName;
    }

    public abstract void DisplayRequirements();
}

public class SoftwareEngineer : JobRole
{
    public SoftwareEngineer()
        : base("Software Engineer")
    {
    }

    public override void DisplayRequirements()
    {
        Console.WriteLine(
            "Requirements: C#, Java, DSA, OOP, SQL"
        );
    }
}

public class DataScientist : JobRole
{
    public DataScientist()
        : base("Data Scientist")
    {
    }

    public override void DisplayRequirements()
    {
        Console.WriteLine(
            "Requirements: Python, Statistics, Machine Learning, SQL"
        );
    }
}

public abstract class Resume
{
    public string CandidateName { get; set; }

    protected Resume(string candidateName)
    {
        CandidateName = candidateName;
    }

    public abstract void DisplayResume();
}

public class Resume<T> : Resume
    where T : JobRole
{
    public T JobRole { get; set; }

    public Resume(string candidateName, T jobRole)
        : base(candidateName)
    {
        JobRole = jobRole;
    }

    public override void DisplayResume()
    {
        Console.WriteLine($"Candidate : {CandidateName}");
        Console.WriteLine($"Role      : {JobRole.RoleName}");

        JobRole.DisplayRequirements();

        Console.WriteLine("----------------------------");
    }
}

public static class ResumeScreening
{
    public static void ScreenResume<T>(Resume<T> resume)
        where T : JobRole
    {
        Console.WriteLine(
            $"Screening {resume.CandidateName} for {resume.JobRole.RoleName}"
        );

        resume.JobRole.DisplayRequirements();

        Console.WriteLine("Resume screened successfully.");
        Console.WriteLine();
    }
}