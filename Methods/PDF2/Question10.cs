using System;

public class Question10
{
    public static void Run()
    {
        Console.WriteLine("Question 10: BMI calculator");
        double[,] people = new double[10, 3];

        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Enter weight (kg) for person {i + 1}: ");
            people[i, 0] = Convert.ToDouble(Console.ReadLine());

            Console.Write($"Enter height (cm) for person {i + 1}: ");
            people[i, 1] = Convert.ToDouble(Console.ReadLine());
        }

        string[] statuses = Program.CalculateBMIAndStatus(people);
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Person {i + 1}: BMI = {people[i, 2]:0.00}, Status = {statuses[i]}");
        }
    }
}
