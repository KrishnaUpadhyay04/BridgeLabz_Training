using System;

public class StudentVoteChecker
{
    public static bool CanStudentVote(int age)
    {
        if (age < 0) return false;
        return age >= 18;
    }
}

public class Question7
{
    public static void Run()
    {
        Console.WriteLine("Question 7: Student voting eligibility");
        int[] ages = new int[10];
        for (int i = 0; i < ages.Length; i++)
        {
            Console.Write($"Enter age of student {i + 1}: ");
            ages[i] = Convert.ToInt32(Console.ReadLine());
        }

        for (int i = 0; i < ages.Length; i++)
        {
            Console.WriteLine($"Student {i + 1}: {(StudentVoteChecker.CanStudentVote(ages[i]) ? "Can vote" : "Cannot vote")}");
        }
    }
}
