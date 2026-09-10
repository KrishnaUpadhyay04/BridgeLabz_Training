using FlightBooking;

class Program
{
    public static void Main(string[] args)
    {
        FlightBooking flightBooking = new FlightBooking();

        flightBooking.ProcessBooking();

        Console.WriteLine();
        Console.WriteLine("ALLOCATIONS");

        foreach (var allocation in flightBooking.GetAllocations())
        {
            Console.WriteLine($"{allocation.BookingId} - " + $"{allocation.PassengerName} - " + $"{allocation.SeatClass} - " + $"{allocation.SeatNumber}");
        }

        Console.WriteLine();

        Console.WriteLine($"Remaining Economy Seats: " + $"{flightBooking.GetRemainingEconomySeats()}");

        Console.WriteLine($"Remaining Business Seats: " + $"{flightBooking.GetRemainingBusinessSeats()}");

        Console.WriteLine();
        Console.WriteLine("REJECTED");

        flightBooking.DisplayRejectedFlights();
    }
}