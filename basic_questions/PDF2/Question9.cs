using System;

class Question9
{
    public static void Solution()
    {
        Console.Write("Enter side 1 in meters: ");
        double side1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter side 2 in meters: ");
        double side2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter side 3 in meters: ");
        double side3 = Convert.ToDouble(Console.ReadLine());

        double perimeter = side1 + side2 + side3;
        double rounds = 5000 / perimeter;

        Console.WriteLine($"The total number of rounds the athlete will run is {rounds} to complete 5 km");
    }
}
