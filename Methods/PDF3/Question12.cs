using System;

public class Question12
{
    public static void Run()
    {
        Console.WriteLine("Question 12: Student scorecard");
        Console.Write("Enter number of students: ");
        int count = Convert.ToInt32(Console.ReadLine());

        int[,] scores = Program.GeneratePCMResults(count);
        double[,] resultTable = Program.CalculateStudentResult(scores);
        Program.DisplayScorecard(resultTable);
    }
}
