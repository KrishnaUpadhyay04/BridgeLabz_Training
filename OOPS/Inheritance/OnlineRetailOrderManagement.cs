using System;

class Order
{
    public string OrderId {get;}
    public DateTime OrderDate {get;}

    public Order(string OrderId, DateTime OrderDate)
    {
        this.OrderId = OrderId;
        this.OrderDate = OrderDate;
    }

    public virtual string GetOrderStatus()
    {
        return "Order Placed";
    }

     public virtual void DisplayDetails()
    {
        Console.WriteLine($"Order ID   : {OrderId}");
        Console.WriteLine($"Order Date : {OrderDate:dd/MM/yyyy}");
        Console.WriteLine($"Status     : {GetOrderStatus()}");
    }
}

class ShippedOrder : Order
{
    public string TrackingNumber { get; }

    public ShippedOrder(string OrderId, DateTime OrderDate, string TrackingNumber) : base(OrderId, OrderDate)
    {
        this.TrackingNumber = TrackingNumber;
    }

    public override string GetOrderStatus()
    {
        return "Order Shipped";
    }

    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"Tracking Number : {TrackingNumber}");
    }
}

class DeliveredOrder : ShippedOrder
{
    public DateTime DeliveryDate { get; }

    public DeliveredOrder(string OrderId, DateTime OrderDate, string TrackingNumber, DateTime DeliveryDate) : base(OrderId, OrderDate, TrackingNumber)
    {
        this.DeliveryDate = DeliveryDate;
    }

    public override string GetOrderStatus()
    {
        return "Order Delivered";
    }

    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"Delivery Date : {DeliveryDate:dd/MM/yyyy}");
    }
}