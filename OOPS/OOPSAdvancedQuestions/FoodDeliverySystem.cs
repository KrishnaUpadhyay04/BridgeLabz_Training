using System;

namespace FoodDeliverySystem
{
    interface IDiscountable
    {
        double ApplyDiscount();

        string GetDiscountDetails();
    }

    abstract class FoodItem
    {
        public string ItemName { get; private set; }
        public double Price { get; private set; }
        public int Quantity { get; private set; }

        public FoodItem()
        {
            ItemName = "Unknown";
            Price = 0.0;
            Quantity = 0;
        }

        public FoodItem(string itemName, double price, int quantity)
        {
            ItemName = itemName;
            Price = price;
            Quantity = quantity;
        }

        public abstract double CalculateTotalPrice();

        public void GetItemDetails()
        {
            Console.WriteLine($"Item Name : {ItemName}");
            Console.WriteLine($"Price     : {Price}");
            Console.WriteLine($"Quantity  : {Quantity}");
        }
    }

    class VegItem : FoodItem, IDiscountable
    {
        public double AdditionalCharge { get; private set; }
        public double DiscountRate { get; private set; }

        public VegItem() : base()
        {
            AdditionalCharge = 0;
            DiscountRate = 0;
        }

        public VegItem(string itemName, double price, int quantity,
                       double additionalCharge, double discountRate)
            : base(itemName, price, quantity)
        {
            AdditionalCharge = additionalCharge;
            DiscountRate = discountRate;
        }

        public override double CalculateTotalPrice()
        {
            return (Price * Quantity) + AdditionalCharge - ApplyDiscount();
        }

        public double ApplyDiscount()
        {
            return Price * Quantity * DiscountRate;
        }

        public string GetDiscountDetails()
        {
            return $"Discount Rate : {DiscountRate:P}";
        }
    }

    class NonVegItem : FoodItem, IDiscountable
    {
        public double AdditionalCharge { get; private set; }
        public double DiscountRate { get; private set; }

        public NonVegItem() : base()
        {
            AdditionalCharge = 0;
            DiscountRate = 0;
        }

        public NonVegItem(string itemName, double price, int quantity,
                          double additionalCharge, double discountRate)
            : base(itemName, price, quantity)
        {
            AdditionalCharge = additionalCharge;
            DiscountRate = discountRate;
        }

        public override double CalculateTotalPrice()
        {
            return (Price * Quantity) + AdditionalCharge - ApplyDiscount();
        }

        public double ApplyDiscount()
        {
            return Price * Quantity * DiscountRate;
        }

        public string GetDiscountDetails()
        {
            return $"Discount Rate : {DiscountRate:P}";
        }
    }
}
