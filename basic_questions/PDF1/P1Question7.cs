using System;

class P1Question7
{
    public static void Solution()
    {
        double radiusKm = 6378;

        double volumeKm3 = (4.0 / 3.0) * Math.PI * Math.Pow(radiusKm, 3);
        double radiusMiles = radiusKm / 1.609344;
        double volumeMiles3 = (4.0 / 3.0) * Math.PI * Math.Pow(radiusMiles, 3);

        Console.WriteLine($"The volume of earth in cubic kilometers is {volumeKm3:F2} and cubic miles is {volumeMiles3:F2}");
    }
}
