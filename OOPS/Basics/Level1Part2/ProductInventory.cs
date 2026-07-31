using System;

class Product
{
    public string ProductName;
    public double Price {get; private set;}

    public static int TotalProducts;


    public Product(string name, double price)
    {
        ProductName = name;
        Price = price;
        TotalProducts++;
    }

    public void DisplayProductDetails()
    {
        Console.WriteLine($"Product Name  : {ProductName}");
        Console.WriteLine($"Product Price : {Price}");
    }

    public static void DisplayTotalProducts()
    {
        Console.WriteLine($"Total Products: {TotalProducts}");
    }
}