using System.ComponentModel.Design;

namespace CabBooking;

abstract class Vehicle
{
    public string Id {get; private set;}
    public string Fuel {get; private set;}

    public Vehicle(string Id, string Fuel)
    {
        this.Id = Id;
        this.Fuel = Fuel;
    }

    public abstract int AvailableSeats();

    public virtual void DisplayVehicleDetails()
    {
        Console.WriteLine($"Vehicle Id   : {Id}");
        Console.WriteLine($"Fuel Type    : {Fuel}");
    }
}

class Car : Vehicle
{
    Driver driver;

    public int seats = 4;

    public Car(string Id, string Fuel, Driver driver) : base(Id, Fuel)
    {
        this.driver = driver;
    }

    public override int AvailableSeats()
    {
        return seats;
    }

    public override void DisplayVehicleDetails()
    {
        base.DisplayVehicleDetails();
        Console.WriteLine($"Vehicle Type  : Car");
    }
}

class Bike : Vehicle
{
    Driver driver;

    public int seats = 1;

    public Bike(string Id, string Fuel, Driver driver) : base(Id, Fuel)
    {
        this.driver = driver;
    }

    public override int AvailableSeats()
    {
        return seats;
    }

    public override void DisplayVehicleDetails()
    {
        base.DisplayVehicleDetails();
        Console.WriteLine($"Vehicle Type  : Bike");
    }
}