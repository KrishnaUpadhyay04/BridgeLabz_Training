using System;

class Library
{
    public Book book;
    public int Availability {get; private set;}

    public Library()
    {
        book.Author = "Unknown";
        book.Title = "Unkonwn";
        book.Price = 0;
        Availability = 0;
    }

    public Library(string title, string author, double price, int availability)
    {
        book.Title = title;
        book.Author = author;
        book.Price = price;
        Availability = availability;
    }

    public void BorrowBook()
    {
        if(Availability > 0)
        {
            Console.WriteLine("Book Rented!");
            Availability--;
        }
        else
        {
            Console.WriteLine("Book Unavailable. Sorry for inconvenience.");
        }
    }
}