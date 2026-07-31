using System;

internal class Book
{
    public string ISBN;
    protected string Title;
    private string Author;

    public Book(string isbn, string title, string author)
    {
        ISBN = isbn;
        Title = title;
        Author = author;
    }

    public void GetAuthorName()
    {
        Console.WriteLine($"Author's Name: {Author}");
    }

    private void SetAuthorName(string name)
    {
        Author = name;
    }

    public void Display()
    {
        Console.WriteLine($"ISBN   : {ISBN}");
        Console.WriteLine($"Title  : {Title}");
        Console.WriteLine($"Author : {Author}");
    }
}

class EBOOK : Book
{
    public EBOOK(string isbn, string title, string author) : base(isbn, title, author) {}

    public void DisplayEBook()
    {  
        Console.WriteLine("ISBN and Title from E-Book Class.");
        Console.WriteLine($"ISBN   : {ISBN}");
        Console.WriteLine($"Title  : {Title}");
    }
}