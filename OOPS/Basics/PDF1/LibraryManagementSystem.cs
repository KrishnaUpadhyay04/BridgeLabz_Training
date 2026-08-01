using System;

class Book
{
    public static string LibraryName = "Chitkara Public Library";

    public readonly string ISBN;

    public string Title;
    public string Author;

    public Book(string Title, string Author, string ISBN)
    {
        this.Title = Title;
        this.Author = Author;
        this.ISBN = ISBN;
    }

    public static void DisplayLibraryName()
    {
        Console.WriteLine($"Library Name: {LibraryName}");
    }

    public void DisplayBookDetails()
    {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"ISBN: {ISBN}");
    }
}