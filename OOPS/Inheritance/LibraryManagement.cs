using System;

class Book
{
    public string Title;
    public int PublicationYear;

    public Book()
    {
        Title = "Unknown";
        PublicationYear = 0;
    }

    public Book(string Title, int PublicationYear)
    {
        this.Title = Title;
        this.PublicationYear = PublicationYear;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Title: {Title}, Publication Year: {PublicationYear}");
    }
}

class Author : Book
{
    public string Name;
    public string Bio;

    public Author() : base()
    {
        Name = "Unknown";
        Bio = "";
    }

    public Author(string Title, int PublicationYear, string Name, string Bio) : base(Title, PublicationYear)
    {
        this.Name = Name;
        this.Bio = Bio;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Author Name: {Name}, Bio: {Bio}");
    } 
}