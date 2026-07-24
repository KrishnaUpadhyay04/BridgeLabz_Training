using System;

class P1Question13
{
    public static void Solution()
    {
        Console.Write("Enter perimeter of square: ");
        double perimeter = Convert.ToDouble(Console.ReadLine());

        double side = perimeter / 4;

        Console.WriteLine($"The length of the side is {side} whose perimeter is {perimeter}");
    }
}
