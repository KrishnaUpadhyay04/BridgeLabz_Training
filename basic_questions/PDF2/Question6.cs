using System;

class Question6
{
    public static void Solution()
    {
        Console.Write("Enter salary: ");
        double salary = double.Parse(Console.ReadLine());

        Console.Write("Enter bonus: ");
        double bonus = double.Parse(Console.ReadLine());

        double income = salary + bonus;

        Console.WriteLine($"The salary is INR {salary} and bonus is INR {bonus}. Hence Total Income is INR {income}");
    }
}
