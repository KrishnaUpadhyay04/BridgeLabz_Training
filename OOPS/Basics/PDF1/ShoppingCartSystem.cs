using System;

class Product
{
    private static Random random = new Random();
    public static double Discount = 0.1;

    public string ProductName;
    public double ProductPrice {get; internal set;}
    public int ProductQuantity;
    public readonly int ProductId;

    public Product(string ProductName, double ProductPrice, int ProductQuantity)
    {
        this.ProductName = ProductName;
        this.ProductPrice = ProductPrice;
        this.ProductQuantity = ProductQuantity;
        this.ProductId = random.Next(1000, 9999);
    }


    public static void UpdateDiscount(double discount)
    {
        if(discount >= 0 && discount <= 1)
        {
            Discount = discount;
        }

        else Console.WriteLine("Discount should be between 0  and 1");
    }

    public void DisplayProductDetails()
    {
        Console.WriteLine($"Product Id      : {ProductId}");
        Console.WriteLine($"Product Name    : {ProductName}");
        Console.WriteLine($"Product Price   : {ProductPrice}");
        Console.WriteLine($"Product Quantity: {ProductQuantity}");
        Console.WriteLine($"Discount        : {Discount * 100}%");
    }
}