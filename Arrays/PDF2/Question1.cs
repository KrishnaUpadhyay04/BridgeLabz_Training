using System;

class Question1
{
    public static void Solution()
    {
        double[] salary = new double[10];
        double[] yearsOfService = new double[10];
        double[] bonus = new double[10];
        double[] newSalary = new double[10];

        double totalBonus = 0;
        double totalOldSalary = 0;
        double totalNewSalary = 0;

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Employee {i + 1}");

            Console.Write("Enter Salary: ");
            salary[i] = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Years of Service: ");
            yearsOfService[i] = Convert.ToDouble(Console.ReadLine());

            if (salary[i] < 0 || yearsOfService[i] < 0)
            {
                Console.WriteLine("Invalid Input! Enter Again.");
                i--;
                continue;
            }
        }

        Console.WriteLine("\nEmployee Details");

        for (int i = 0; i < 10; i++)
        {
            if (yearsOfService[i] > 5)
                bonus[i] = salary[i] * 0.05;
            else
                bonus[i] = salary[i] * 0.02;

            newSalary[i] = salary[i] + bonus[i];

            totalBonus += bonus[i];
            totalOldSalary += salary[i];
            totalNewSalary += newSalary[i];

            Console.WriteLine($"Employee {i + 1}");
            Console.WriteLine($"Old Salary : {salary[i]}");
            Console.WriteLine($"Bonus      : {bonus[i]}");
            Console.WriteLine($"New Salary : {newSalary[i]}\n");
        }

        Console.WriteLine($"Total Old Salary : {totalOldSalary}");
        Console.WriteLine($"Total Bonus      : {totalBonus}");
        Console.WriteLine($"Total New Salary : {totalNewSalary}");
    }
}