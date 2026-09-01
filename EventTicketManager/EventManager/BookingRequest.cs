namespace EventManager;
using EventManager.Exceptions;
class BookingRequest
{
    public int BookingId {get; private set;}

    public int CustomerId {get; private set;}

    public int SeatId {get; private set;}

    public string RequestdCategory {get; private set;}

    public bool IsAccessibal {get; private set;}



    public BookingRequest(int BookingId, int CustomerId, int SeatId, string RequestedCategory, bool IsAccessibal)
    {
        this.BookingId = BookingId;
        this.CustomerId = CustomerId;
        this.SeatId = SeatId;
        this.RequestedCategory = RequestedCategory;
        this.IsAccessibal = IsAccessibal;
    }

}