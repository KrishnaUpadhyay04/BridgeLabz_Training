using System;
using System.Collections.Generic;

namespace ObjectModeling.Library
{
    class Book
    {
        public string Title;
        public string Author;
        public double Price { get; internal set; }

        public Book()
        {
            Title = "";
            Author = "";
            Price = 0.0;
        }

        public Book(string Title, string Author, double Price)
        {
            this.Title = Title;
            this.Author = Author;
            this.Price = Price;
        }

        public void DisplayBookDetails()
        {
            Console.WriteLine($"Title  : {Title}");
            Console.WriteLine($"Author : {Author}");
            Console.WriteLine($"Price  : {Price}");
        }
    }

    class Library
    {
        public string Name;

        public List<Book> books;

        public int BooksCount { get; private set; }

        public Library(string Name)
        {
            this.Name = Name;
            books = new List<Book>();
            BooksCount = 0;
        }

        public void AddBook(Book book)
        {
            books.Add(book);
            BooksCount++;
        }

        public void DisplayLibraryBooks()
        {
            Console.WriteLine($"Library Name: {Name}");
            Console.WriteLine($"Total Books: {BooksCount}");
            Console.WriteLine("Books in the Library:");
            foreach (var book in books)
            {
                book.DisplayBookDetails();
                Console.WriteLine("------------------------");
            }
        }
    }
}