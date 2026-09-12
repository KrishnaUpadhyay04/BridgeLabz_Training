using System.Runtime.CompilerServices;

namespace FlightBooking.Tests;

public class Tests
{
    private Booking booking; 
    private FlightBooking FlightBooking;
    [SetUp]
    public void Setup()
    {
        booking = new Booking("BK1", "Ajay Mehta", "DEL", "BOM", "Economy");
        FlightBooking = new();
    }

    [Test]
    public void ValidRouteReceivesASeat()
    {
        bool result = booking.isValid();

        Assert.That(result, Is.True);
    }


    [Test]
    public void DuplicateBooking()
    {
        Booking booking1 = new Booking("BK1", "Ajay Mehta", "DEL", "BOM", "Economy");
        FlightBooking.Add(booking1);
        Booking booking2 = new Booking("BK1", "Ajay Mehta", "DEL", "BOM", "Economy");

        Assert.Throws<DuplicateBookingException>(() => FlightBooking.Add(booking2));
    }


    [Test]

    public void InvalidBookingDoesnotConsumeSeat()
    {
        int before = FlightBooking.EconomySeat;

        FlightBooking.Add(new Booking("BK1", "Ajay Mehta", "", "BOM", "Economy"));

        Assert.That(before, Is.EqualTo(FlightBooking.EconomySeat));
    }


    [Test]

    public void FullFlightThrowsSeatUnavailableException()
    {
        FlightBooking.BusinessSeat = 0;

        Assert.Throws<SeatUnavailableException>(() => FlightBooking.Add(new Booking("BK5", " Krishna", "BLR", "BOM", "Business")));
    }


    [Test]

    public void InvalidOriginAirport()
    {
        Assert.Throws<FlightException>(() => FlightBooking.Add(new Booking("BK5", " Krishna", "", "BOM", "Business")));
    }

    [Test]

    public void InvalidDestinationAirport()
    {
        Assert.Throws<FlightException>(() => FlightBooking.Add(new Booking("BK5", " Krishna", "BLR", "", "Business")));
    }
    

}
