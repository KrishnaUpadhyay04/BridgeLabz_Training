using System;

public class Question11
{
    public static void Run()
    {
        Console.WriteLine("Question 11: Employee bonus");
        Random random = new Random();
        double[,] employees = new double[10, 2];
        for (int i = 0; i < 10; i++)
        {
            employees[i, 0] = random.Next(10000, 100000);
            employees[i, 1] = random.Next(1, 15);
        }

        double[,] bonusData = Program.CalculateBonus(employees);
        Console.WriteLine("Employee bonus summary:");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Employee {i + 1}: Old salary = {employees[i, 0]}, Years = {employees[i, 1]}, Bonus = {bonusData[i, 1]}, New salary = {bonusData[i, 0]}");
        }

        Console.WriteLine($"Total old salary: {Program.CalculateTotalOldSalary(employees)}");
        Console.WriteLine($"Total new salary: {Program.CalculateTotalNewSalary(bonusData)}");
        Console.WriteLine($"Total bonus: {Program.CalculateTotalBonus(bonusData)}");
    }
}
