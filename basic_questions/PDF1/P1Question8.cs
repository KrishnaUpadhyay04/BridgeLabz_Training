using System;

class P1Question8
{
    public static void Solution()
    {
        Console.Write("Enter distance in kilometers: ");
        double km = Convert.ToDouble(Console.ReadLine());

        double miles = km / 1.6;

        Console.WriteLine($"The total miles is {miles} mile for the given {km} km");
    }
}
