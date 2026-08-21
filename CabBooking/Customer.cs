namespace CabBooking;

class Customer
{
    public string Name;
    public int Id;

    public List<Ride> rides;

    public Rating ratedriver;


    public Customer(string Name, int Id)
    {
        this.Name = Name;
        this.Id = Id;
        rides = new();
    }

    public void CabRequest(Driver driver, string Pickup, string Drop, double Price, int Seats)
    {
        Ride requestedride = new(this, driver, Pickup, Drop, Price, Seats);
        driver.RequestedRides.Add(requestedride);
    }

    public void RateDriver (Driver driver)
    {
        Console.WriteLine("Enter your comments: ");
        string Comment = Console.ReadLine() ?? "";
        Console.WriteLine("Rate your driver(1-10): ");
        int Points = Convert.ToInt32(Console.ReadLine());
        ratedriver = new(driver, Comment, Points);

        driver.AddRating(ratedriver);
    }

    public void RidesDetails()
    {
        foreach(Ride ride in rides)
        {
            ride.DisplayRideDetails();
        }
    }

    public void PayRideFair(double Price)
    {
        Console.Write("Pay using Cash or UPI?: ");
        string PaymentMethod = Console.ReadLine() ?? "";
        if(PaymentMethod == "Cash")
        {
            CashPayment cash = new();
            cash.PayAmount(Price);
        }

        else
        {
            UPI upi = new();
            upi.PayAmount(Price);
        }
    }
}