using System;
using System.Globalization;

class Question4
{
    public static void Solution()
    {
        Console.WriteLine("Enter the first date: (dd-mm-yyyy): ");
        DateTime date1 = DateTime.ParseExact(Console.ReadLine(), "dd-mm-yyyy", CultureInfo.InvariantCulture);

        Console.WriteLine("Enter the second date: (dd-mm-yyyy): ");
        DateTime date2 = DateTime.ParseExact(Console.ReadLine(), "dd-mm-yyyy", CultureInfo.InvariantCulture);

        int result = DateTime.Compare(date1, date2);

        if(result < 0) Console.WriteLine("The first date is before the second date.");

        else if(result > 0) Console.WriteLine("The first date is after the second date.");

        else Console.WriteLine("Both dates are the same.");
    }
}