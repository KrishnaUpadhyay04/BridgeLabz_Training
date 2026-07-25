using System;

class Question2
{
    public static void Solution()
    {
        Console.WriteLine("Enter length of rectangle: ");
        int length = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter width of rectangle: ");
        int width = Convert.ToInt32(Console.ReadLine());
        int perimeter = 2 * (length + width);
        Console.WriteLine($"Perimeter of rectangle is: {perimeter}");
    }
}