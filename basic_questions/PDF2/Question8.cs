using System;

class Question8
{
    public static void Solution()
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        Console.Write("Enter from city: ");
        string fromCity = Console.ReadLine();

        Console.Write("Enter via city: ");
        string viaCity = Console.ReadLine();

        Console.Write("Enter to city: ");
        string toCity = Console.ReadLine();

        Console.Write("Enter distance from to via in miles: ");
        double fromToVia = double.Parse(Console.ReadLine());

        Console.Write("Enter distance via to final city in miles: ");
        double viaToFinalCity = double.Parse(Console.ReadLine());

        Console.Write("Enter time taken: ");
        double timeTaken = double.Parse(Console.ReadLine());

        double totalDistance = fromToVia + viaToFinalCity;
        double averageSpeed = totalDistance / timeTaken;

        Console.WriteLine($"The results of the trip are: {name}, {fromCity}, {viaCity}, {toCity}, {totalDistance}, and {averageSpeed}");
    }
}
