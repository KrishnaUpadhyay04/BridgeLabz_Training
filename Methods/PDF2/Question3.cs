using System;

public class Question3
{
    public static void Run()
    {
        Console.WriteLine("Question 3: Leap year");
        Console.Write("Enter a year: ");
        int year = Convert.ToInt32(Console.ReadLine());

        bool isLeapYear = Program.IsLeapYear(year);
        Console.WriteLine(isLeapYear ? "The year is a leap year" : "The year is not a leap year");
    }
}
