using System;

class P1Question10
{
    public static void Solution()
    {
        Console.Write("Enter height in centimeters: ");
        double heightCm = Convert.ToDouble(Console.ReadLine());

        double totalInches = heightCm / 2.54;
        double feet = totalInches / 12;
        double inches = totalInches % 12;

        Console.WriteLine($"Your Height in cm is {heightCm} while in feet is {feet:F2} and inches is {inches:F2}");
    }
}
