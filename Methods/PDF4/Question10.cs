using System;

public class Question10
{
    public static void Run()
    {
        Console.WriteLine("Question 10: Collinear points");
        Console.Write("Enter x1: ");
        double x1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter y1: ");
        double y1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter x2: ");
        double x2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter y2: ");
        double y2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter x3: ");
        double x3 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter y3: ");
        double y3 = Convert.ToDouble(Console.ReadLine());

        bool slopeResult = Program.AreCollinearBySlope(x1, y1, x2, y2, x3, y3);
        bool areaResult = Program.AreCollinearByArea(x1, y1, x2, y2, x3, y3);

        Console.WriteLine($"Collinear by slope: {slopeResult}");
        Console.WriteLine($"Collinear by area: {areaResult}");
    }
}
