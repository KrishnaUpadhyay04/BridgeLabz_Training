using System;

class P1Question14
{
    public static void Solution()
    {
        Console.Write("Enter distance in feet: ");
        double distanceInFeet = Convert.ToDouble(Console.ReadLine());

        double distanceInYards = distanceInFeet / 3;
        double distanceInMiles = distanceInYards / 1760;

        Console.WriteLine($"The distance is {distanceInYards} yards and {distanceInMiles} miles for the given {distanceInFeet} feet");
    }
}
