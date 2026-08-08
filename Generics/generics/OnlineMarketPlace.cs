using System;

public abstract class ProductCategory
{
    public string CategoryName { get; set; }

    protected ProductCategory(string categoryName)
    {
        CategoryName = categoryName;
    }
}


public class BookCategory : ProductCategory
{
    public BookCategory()
        : base("Books")
    {
    }
}


public class ClothingCategory : ProductCategory
{
    public ClothingCategory()
        : base("Clothing")
    {
    }
}


public class Product<T> where T : ProductCategory
{
    public string Name { get; set; }
    public double Price { get; set; }
    public T Category { get; set; }

    public Product(string name, double price, T category)
    {
        Name = name;
        Price = price;
        Category = category;
    }

    public void DisplayProduct()
    {
        Console.WriteLine($"Product Name : {Name}");
        Console.WriteLine($"Price        : {Price}");
        Console.WriteLine($"Category     : {Category.CategoryName}");
    }
}


public static class Marketplace
{
    public static void ApplyDiscount<TCategory>(
        Product<TCategory> product,
        double percentage)
        where TCategory : ProductCategory
    {
        product.Price -= product.Price * percentage / 100;
    }
}
