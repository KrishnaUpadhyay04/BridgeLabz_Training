namespace EventManager;

using System.ComponentModel.Design.Serialization;
using EventManager.Models;

class Category
{
    public string Type {get; private set;}     // Silver, Gold, Premium, VIP

    private List<Seats> seats;
    public double BasePrice {get; private set;}
    public int SeatCount {get; private set;}


    public Category(string Type, int SeatCount, double BasePrice)
    {
        this.Type = Type;
        this.BasePrice = BasePrice;
        this.SeatCount = SeatCount;
    }

    public void UpdatePrice()
    {
        if(seats.Count >= SeatCount * 0.4 && seats.Count < SeatCount * 0.8) BasePrice += BasePrice * 0.1;

        if(seats.Count >= SeatCount * 0.8) BasePrice += BasePrice * 0.3;
    }

    public void AddSeat(Seats seat)
    {
        seats.Add(seat);
    }

}