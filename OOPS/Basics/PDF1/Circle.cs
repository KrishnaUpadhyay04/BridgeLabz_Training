using System;

class Circle
{
    private const double pi = 3.14;
    private double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public double CalculateArea() {return pi * radius * radius;}

    public double CalculatePerimeter() {return 2 * pi * radius;}

    public void DisplayArea() {Console.WriteLine("Area: " + CalculateArea());}

    public void DisplayPerimeter() {Console.WriteLine("Perimeter: " + CalculatePerimeter());}
}