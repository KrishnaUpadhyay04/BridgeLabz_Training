using System;

class Vehicle
{
    public static int RegistrationFees = 500;

    public string OwnerName;
    public string VehicleType;
    public readonly string RegistrationNumber;


    public static void UpdateRegistrationFees(int newFees)
    {
        RegistrationFees = newFees;
    }

    public Vehicle(string OwnerName, string VehicleType, string RegistrationNumber)
    {
        this.OwnerName = OwnerName;
        this.VehicleType = VehicleType;
        this.RegistrationNumber = RegistrationNumber;
    }

    public void DisplayVehicleDetails()
    {
        Console.WriteLine($"Owner Name: {OwnerName}");
        Console.WriteLine($"Vehicle Type: {VehicleType}");
        Console.WriteLine($"Registration Number: {RegistrationNumber}");
        Console.WriteLine($"Registration Fees: {RegistrationFees}");
    }
}