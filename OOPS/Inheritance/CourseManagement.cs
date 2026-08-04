using System;

class Course
{
    public string CourseName;
    public TimeSpan Duration;

    public Course()
    {
        CourseName = "Unknown";
        Duration = TimeSpan.Zero;
    }

    public Course(string CourseName, TimeSpan Duration)
    {
        this.CourseName = CourseName;
        this.Duration = Duration;
    }

    public virtual void DisplayCourseInfo()
    {
        Console.WriteLine($"Course Name: {CourseName}, Duration: {Duration}");
    }

}

class OnlineCourse : Course
{
    public string Platform;
    public bool IsRecorded;

    public OnlineCourse() : base()
    {
        Platform = "Unknown";
        IsRecorded = false;
    }

    public OnlineCourse(string CourseName, TimeSpan Duration, string Platform, bool IsRecorded) : base(CourseName, Duration)
    {
        this.Platform = Platform;
        this.IsRecorded = IsRecorded;
    }

    public override void DisplayCourseInfo()
    {
        base.DisplayCourseInfo();
        Console.WriteLine($"Platform: {Platform}, Is Recorded: {(IsRecorded ? "Yes" : "No")}");
    }
}

class PaidOnlineCourse : OnlineCourse
{
    public double Fees;
    public double Discount;

    public PaidOnlineCourse() : base()
    {
        Fees = 0.0;
        Discount = 0.0;
    }

    public PaidOnlineCourse(string CourseName, TimeSpan Duration, string Platform, bool IsRecorded, double Fees, double Discount) 
        : base(CourseName, Duration, Platform, IsRecorded)
    {
        this.Fees = Fees;
        this.Discount = Discount;
    }

    public override void DisplayCourseInfo()
    {
        base.DisplayCourseInfo();
        Console.WriteLine($"Fees: {Fees}, Discount: {Discount}");
    }
}