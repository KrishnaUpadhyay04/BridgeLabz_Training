using System;

public class Question8
{
    public static void Run()
    {
        Console.WriteLine("Question 8: Calendar");
        Console.Write("Enter month (1-12): ");
        int month = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter year: ");
        int year = Convert.ToInt32(Console.ReadLine());

        Program.DisplayCalendar(month, year);
    }
}
