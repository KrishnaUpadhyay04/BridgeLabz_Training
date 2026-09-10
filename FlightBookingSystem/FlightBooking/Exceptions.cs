namespace FlightBooking.Exceptions;

public class FlightException : Exception
{
    public FlightException(string message) : base(message);
}

public class InvalidAirportCodeException : FlightException
{
    public InvalidAirportCodeException(string message) : base(message);
}

public class DuplicateBookingException : Exception
{
    public DuplicateBookingException(string message) : base(message);
}

public class SeatUnavailableException : Exception
{
    public SeatUnavailableException(string message) : base(message);
}