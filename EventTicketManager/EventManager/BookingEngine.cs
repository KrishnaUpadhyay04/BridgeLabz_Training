using System.ComponentModel;
using System.Reflection;

namespace EventManager;

class BookingEngine
{
    private List<Seats> seats;

    private List<Bookings> bookings;

    private Dictionary<Categories, int> categories;

    private HashSet<string> SoldOutCategories;

    private Func<Seats, double> PricingRule;

    private event Action<Seats, double>? PriceAdjusted;

    private event Action<string>? CategorySoldOut;


    public BookingEngine(List<Seats> seats, double DemandFactor)
    {
        this.seats = seats;

        bookings = new List<Bookings>();

        SoldOutCategories = new HashSet<string>();

        PricingRule = CreateDynamicPricingRule(DemandFactor);
    }

    private Func<Seats, double> CreateDynamicPricingRule(double DemandFactor)
    {
        return seat =>
        {
            double RemainingPercentage = GetRemainingInventoryPercentage();

            if(RemainingPercentage < 20)
            {
                double increase = seat.BasePrice * DemandFactor;

                return seat.BasePrice + increase;
            }
            return seat.BasePrice;
        };
    }

    private double GetRemainingInventoryPercentage()
    {
        if(seats.Count == 0) return 0;

        int remaining = seats.Count(s => !s.IsBooked && !s.IsHeld);

        return (double) remaining / seats.Count * 100;
    }

    private Predicate<Seats> GetAvailabilityPredicate()
    {
        return seat => !seat.IsBooked && !seat.IsHeld;
    }

    private bool HasAccessibleSeatingAttribute()
    {
        MethodInfo? method = typeof(BookingEngine).GetMethod(nameof(IsAccessibleSeat, BindingFlags.NonPublic | BindingFlags.Instance));

        return method?.GetCustomAttribute<AccessibleSeatingAttribute>();
    }
    
    [AccesibleSeatingAttribute]
    private bool IsAccessibleSeat()
    {
        return seat => !seat.IsHeld && !seat.IsBooked;
    }

    public AddCategory(Category category)
    {
        categories.Add(category, category.SeatCount);
    }


    public void CheckCategoryAvailablity(Category category)
    {
        return !(categories[category] == 0);
    }
}