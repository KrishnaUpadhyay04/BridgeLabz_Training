namespace EventManager;


public interface IDisposable
{
    void Cleanup();
}
public class ReservationHold : IDisposable
{
    private Seats Seat;
    private DateTime ExpiryTime;

    private bool disposed;
    public bool IsExpired => DateTime.UtcNow >= ExpiryTime;

    public ReservationHold(Seats Seat, TimeSpan Duration)
    {
        this.Seat = Seat;
        ExpiryTime = DateTime.UtcNow.Add(Duration);

        if(Seat.IsBooked) throw new SeatUnavailableException(Seat.SeatId, "Seat Already Booked.");

        if(Seat.IsHeld) throw new SeatUnavailableException(Seat.SeatID, "Seat is Being Held.");
    }

    public void Cleanup()
    {
        if(IsExpired)
        {
            Seat = null;

            throw new TimeoutException("Session Expired.");
        }
    }
}