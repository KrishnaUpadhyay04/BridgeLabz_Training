namespace CabBooking;

class Ride
{
    public Customer customer {get; private set;}
    public Driver driver{get; private set;}

    public DateTime TimeOfRide;
    public string Pickup;
    public string Drop;
    public int Seats;
    public double Price {get; private set;}



    public Ride(Customer customer, Driver driver, string Pickup, string Drop, double Price, int Seats)
    {
        this.customer = customer;
        this.driver = driver;
        this.Pickup = Pickup;
        this.Drop = Drop;
        this.Price = Price;
        this.Seats = Seats;
    }

    public Ride(Customer customer, Driver driver, string Pickup, string Drop, double Price, DateTime time, int Seats)
    {
        this.customer = customer;
        this.driver = driver;
        this.Pickup = Pickup;
        this.Drop = Drop;
        this.Price = Price;
        TimeOfRide = time;
        this.Seats = Seats;
    }

    public void DisplayRideDetails()
    {
        Console.WriteLine($"Customer Name : {customer.Name}");
        Console.WriteLine($"Driver's Name : {driver.Name}");
        Console.WriteLine($"PickUp Point  : {Pickup}");
        Console.WriteLine($"Drop Point    : {Drop}");
        Console.WriteLine($"Fair          : {Price}");
    }
}