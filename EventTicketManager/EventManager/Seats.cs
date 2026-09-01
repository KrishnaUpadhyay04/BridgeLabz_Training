using System.Diagnostics.Contracts;

namespace EvenetManager.Models;

class Seat
{
    public int SeatId {get; private set;}
    public string Category {get; private set;}
    public double BasePrice {get; private set;}
    public bool IsBooked {get; private set;}

    public bool IsHeld {get; private set;}


    public Seat(int SeatId, string Category, double BasePrice)
    {
        this.SeatId = SeatId;
        this.Category = Category;
        this.BasePrice = BasePrice;
        IsBooked = false;
        IsHeld = false;
    }

    

}