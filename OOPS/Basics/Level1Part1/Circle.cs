using System;

class Circle
{
    public double Radius {get; private set;}

    public Circle() : this(1.0)
    {
        
    }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public void Display()
    {
        Console.WriteLine($"Radius: {Radius}");
    }
}