using System;

class Question2
{
    public static void Solution()
    {
        Console.WriteLine("Enter a date (dd-MM-yyyy): ");

        DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", null);

        DateTime result =  date.AddDays(7).AddMonths(1).AddYears(2);

        result = result.AddDays(-21);

        Console.WriteLine($"\nOriginal Date: {date:dd-MM-yyyy}");
        Console.WriteLine($"Final Date: {result:dd-MM-yyyy}");
    }
}