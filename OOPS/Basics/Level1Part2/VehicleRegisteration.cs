using System;

public class Vehicle
{
    public string OwnerName;
    public string VehicleType;
    public static double RegisterationFee;

    public Vehicle(string OwnerName, string VehicleType)
    {
        this.OwnerName = OwnerName;
        this.VehicleType = VehicleType;
    }

    public void DisplayVehicleDetails()
    {
        Console.WriteLine($"Owner Name: {OwnerName}");
        Console.WriteLine($"Vehicle Type: {VehicleType}");
    }

    public static void UpdateRegisterationFee(double fee)
    {
        RegisterationFee = fee;
    }
}