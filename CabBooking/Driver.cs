namespace CabBooking;

class Driver
{
    public string Name;
    Vehicle vehicle;

    List<Ride> rides;
    List<Rating> ratings;

    internal List<Ride> RequestedRides;


    public Driver(string Name, Vehicle vehicle)
    {
        this.Name = Name;
        this.vehicle = vehicle;
        rides = new();
        ratings = new();
        RequestedRides = new();
    }

    public void AcceptRide()
    {
        foreach(Ride requested in RequestedRides)
        {
            if(vehicle.AvailableSeats() >= requested.Seats)
            {
                Console.WriteLine("Excepted!");

                Ride accepted = new(requested.customer, requested.driver, requested.Pickup, requested.Drop, requested.Price, DateTime.Now, requested.Seats);

                rides.Add(accepted);
                requested.customer.rides.Add(accepted);
            }
        }
    }

    public void AddRating(Rating rate)
    {
        ratings.Add(rate);
    }

    public void RidesDetails()
    {
        foreach(Ride ride in rides)
        {
            ride.DisplayRideDetails();
        }
    }
}