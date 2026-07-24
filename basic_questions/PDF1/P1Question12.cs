using System;

class P1Question12
{
    public static void Solution()
    {
        Console.Write("Enter base: ");
        double baseValue = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter height: ");
        double height = Convert.ToDouble(Console.ReadLine());

        double areaInSquareInches = 0.5 * baseValue * height;
        double areaInSquareCentimeters = areaInSquareInches * 6.4516;

        Console.WriteLine($"The area of the triangle is {areaInSquareInches} square inches and {areaInSquareCentimeters} square centimeters");
    }
}
