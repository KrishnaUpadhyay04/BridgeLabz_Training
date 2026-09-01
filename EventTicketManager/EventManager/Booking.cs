using Microsoft.CSharp.RuntimeBinder;

namespace EventManager;

class Booking
{
    public int RequestId {get; private set;}
    public int CustomerId {get; private set;}
    public int SeatId {get; private set;}
    public string Category {get; private set;}
    public double Price {get; private set;}


    public Booking(int RequestId, int CustomerId, int SeatId, string Category, double Price)
    {
        this.RequestId = RequestId;
        this.CustomerId = CustomerId;
        this.SeatId = SeatId;
        this.Category = Category;
        this.Price = Price;
    }
}