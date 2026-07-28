using System;

public class Question11
{
    public static void Run()
    {
        Console.WriteLine("Question 11: Employee bonus");
        Console.Write("Enter number of employees: ");
        int count = Convert.ToInt32(Console.ReadLine());

        double[,] employees = new double[count, 2];
        for (int i = 0; i < count; i++)
        {
            Console.Write($"Employee {i + 1} salary: ");
            employees[i, 0] = Convert.ToDouble(Console.ReadLine());
            Console.Write($"Employee {i + 1} years of service: ");
            employees[i, 1] = Convert.ToDouble(Console.ReadLine());
        }

        double[,] result = Program.CalculateBonus(employees);
        Console.WriteLine("Updated salaries and bonuses:");
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine($"Employee {i + 1}: new salary = {result[i, 0]}, bonus = {result[i, 1]}");
        }
        Console.WriteLine($"Total old salary: {Program.CalculateTotalOldSalary(employees)}");
        Console.WriteLine($"Total new salary: {Program.CalculateTotalNewSalary(result)}");
        Console.WriteLine($"Total bonus: {Program.CalculateTotalBonus(result)}");
    }
}
