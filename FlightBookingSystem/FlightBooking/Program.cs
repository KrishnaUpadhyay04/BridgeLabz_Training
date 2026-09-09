using FlightBooking;
using FlightBooking.Models;

class Program
{
    public static void Main(string[] args)
    {
        FlightBooking FlightBooking = new FlightBooking();

        Booking B1 = new("BK1", "Ajay Mehta", "DEL", "BOM", "Economy");
        Booking B2 = new("BK2", "Ritu Sharma", "BOM", "BLR", "Business");

        FlightBooking.AddBooking(B1);

        FlightBooking.AddBooking(B2);
    }
}