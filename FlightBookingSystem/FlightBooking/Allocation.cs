namespace FlightBooking.Models;

public class Allocation
{
    public string BookingId { get; set; }
    public string PassengerName { get; set; }
    public string FromCode { get; set; }
    public string ToCode { get; set; }
    public string SeatClass { get; set; }
    public string SeatNumber { get; set; }

    public Allocation(string bookingId, string passengerName, string fromCode, string toCode, string seatClass, string seatNumber)
    {
        BookingId = bookingId;
        PassengerName = passengerName;
        FromCode = fromCode;
        ToCode = toCode;
        SeatClass = seatClass;
        SeatNumber = seatNumber;
    }
}