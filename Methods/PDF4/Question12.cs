using System;

public class Question12
{
    public static void Run()
    {
        Console.WriteLine("Question 12: Student scorecard");
        Console.Write("Enter number of students: ");
        int count = Convert.ToInt32(Console.ReadLine());

        double[,] students = new double[count, 3];
        for (int i = 0; i < count; i++)
        {
            Console.Write($"Student {i + 1} marks: ");
            students[i, 0] = Convert.ToDouble(Console.ReadLine());
            Console.Write($"Student {i + 1} total marks: ");
            students[i, 1] = Convert.ToDouble(Console.ReadLine());
            Console.Write($"Student {i + 1} grade points: ");
            students[i, 2] = Convert.ToDouble(Console.ReadLine());
        }

        Console.WriteLine("Student results:");
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine($"Student {i + 1}: percentage = {Program.CalculatePercentage(students[i, 0], students[i, 1])}, grade = {Program.CalculateGrade(students[i, 2])}");
        }
    }
}
