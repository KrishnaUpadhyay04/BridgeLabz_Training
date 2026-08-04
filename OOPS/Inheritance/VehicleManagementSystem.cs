namespace VehicleManagementSystem;

interface Refuelable
{
    public void Refuel();
}

class Vehicle
{
    public int MaxSpeed;
    public string Model;

    public Vehicle()
    {
        MaxSpeed = 0;
        Model = "";
    }

    public Vehicle(int MaxSpeed, string Model)
    {
        this.MaxSpeed = MaxSpeed;
        this.Model = Model;
    }

    public virtual void DisplayDetails()
    {
        Console.WriteLine($"MaxSpeed : {MaxSpeed}");
        Console.WriteLine($"Model    : {Model}");
    }
}

class PetrolVehicle : Vehicle, Refuelable
{
    public static string Type = "Petrol";
    public void Refuel()
    {
        Console.WriteLine("Car Refuled!");
    }

    public PetrolVehicle() : base() {}

    public PetrolVehicle(int MaxSpeed, string Model) : base(MaxSpeed, Model) {}

    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"Type     : {Type}");
    }
}

class ElectricVehicle : Vehicle
{
    public static string Type = "Electric";

    public ElectricVehicle() : base() {}

    public ElectricVehicle(int MaxSpeed, string Model) : base(MaxSpeed, Model) {}

    public void Charge()
    {
        Console.WriteLine("Car Charged!");
    }

    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"Type     : {Type}");
    }
}