using System;

public class Question6
{
    public static void Run()
    {
        Console.WriteLine("Question 6: Spring Season");
        Console.Write("Enter month: ");
        int month = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter day: ");
        int day = Convert.ToInt32(Console.ReadLine());

        bool isSpring = Program.IsSpringSeason(month, day);
        Console.WriteLine(isSpring ? "Its a Spring Season" : "Not a Spring Season");
    }
}
