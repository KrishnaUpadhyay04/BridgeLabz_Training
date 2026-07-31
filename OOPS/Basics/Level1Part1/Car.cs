using System;
using System.Net.Http.Headers;

class Car
{
    public string CustomerName;
    public string CarModel;
    public int RentalDays;

    private const int Fees = 1000;

    public Car(string name, string model, int days)
    {
        CustomerName = name;
        CarModel = model;
        RentalDays = days;
    }

    public void DisplayFees()
    {
        Console.WriteLine($"Total cost for {CarModel} over a period of {RentalDays} days is: {RentalDays * Fees}");
    }
}