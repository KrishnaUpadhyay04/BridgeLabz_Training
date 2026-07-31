using System;
using System.Diagnostics.Contracts;

internal class Book
{
    public string Title;
    public string Author;
    public double Price {get; internal set;}

    public Book()
    {
        Title = "";
        Author = "";
        Price = 0.0;
    }

    public Book(string title, string author, double price)
    {
        Title = title;
        Author = author;
        Price = price;
    }

    public void DisplayDetails()
    {
        Console.WriteLine($"Title  : {Title}");
        Console.WriteLine($"Author : {Author}");
        Console.WriteLine($"Price  : {Price}");
    }

}