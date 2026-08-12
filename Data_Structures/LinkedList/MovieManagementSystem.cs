using System.Globalization;
using System.Xml;

namespace LinkedList;

class MovieNode
{
    public string MovieTitle;
    public string MovieDirector;
    public int YearOfRelease;
    public double Rating;

    public MovieNode? prev, next;

    public MovieNode(string MovieTitle, string MovieDirector, int YearOfRelease, double Rating)
    {
        this.MovieTitle = MovieTitle;
        this.MovieDirector = MovieDirector;
        this.YearOfRelease = YearOfRelease;
        this.Rating = Rating;
        prev = next = null;
    }

    public void DisplayDetails()
    {
        Console.WriteLine("--------------------------------");
        Console.WriteLine($"Movie Title    : {MovieTitle}");
        Console.WriteLine($"Director       : {MovieDirector}");
        Console.WriteLine($"Year OfRelease : {YearOfRelease}");
        Console.WriteLine($"IMBD Ratings   : {Rating}");
        Console.WriteLine("--------------------------------");
    }
}

class DoublyLinkedList
{
    MovieNode? head;
    MovieNode? tail;
    
    public void AddAtStart(MovieNode movie)
    {
        if(head == null)
        {
            head = movie;
            if(tail == null)tail = movie;
            return;
        }
        movie.next = head;
        head.prev = movie;
        head = movie;
    }

    public void AddAtEnd(MovieNode movie)
    {
        if(tail == null)
        {
            if(head == null) head = movie;
            tail = movie;
            return;
        }

        tail.next = movie;
        movie.prev = tail;
        tail = movie;
    }

    public void AddAtPosition(MovieNode movie, int position)
    {
        if(position < 1)
        {
            Console.WriteLine("Invalid position");
            return;
        }

        if(position == 1)
        {
            AddAtStart(movie);
            return;
        }

        int curr = 1;

        if(head == null) return;
        if(position == 1)
        {
            movie.next = head;
            head.prev = movie;
            head = movie;
            return;
        }

        MovieNode? temp = head;
        while(curr < position - 1)
        {
            if(temp == null)
            {
                Console.WriteLine("Position out of bounds!");
                return;
            }
            temp = temp.next;
            curr++;
        }
        movie.next = temp?.next;
        movie?.next?.prev = movie;
        temp?.next = movie;


        // Edge Case: Insertion at tail
        if(movie?.next == null) tail = movie;
    }

    public void RemoveMovieByTitle(string Title)
    {
        if(head == null)
        {
            Console.WriteLine("Movie doesn't exist in records.");
            return;
        }

        if(head.MovieTitle == Title)
        {
            head = head.next;
            if(head != null) head.prev = null;
            else tail = null;
            return;
        }

        MovieNode temp = head;
        while(temp.next != null)
        {
            if(temp.next.MovieTitle == Title)
            {
                if(temp.next == tail)
                {
                    tail = temp;
                    temp.next = null;
                    return;
                }
                temp.next = temp.next.next;
                temp.next?.prev = temp;
                return;
            }
            temp = temp.next;
        }
    }

    public bool SearchMovieByDirector(string Director)
    {
        if(head == null) return false;

        MovieNode temp = head;
        while(temp != null)
        {
            if(temp.MovieDirector == Director) return true;
            temp = temp.next;
        }

        return false;
    }

    public bool SearchMovieByRating(double Rating)
    {
        if(head == null) return false;

        MovieNode temp = head;
        while(temp != null)
        {
            if(temp.Rating == Rating) return true;
            temp = temp.next;
        }

        return false;
    }

    public void DisplayRecordsinForward()
    {
        MovieNode? temp = head;

        while(temp != null)
        {
            temp.DisplayDetails();
            temp = temp.next;
        }
    }

    public void DisplayRecordsinBackward()
    {
        MovieNode? temp = tail;

        while(temp != null)
        {
            temp.DisplayDetails();
            temp = temp.prev;
        }
    }

    public void UpdateMovieRatingsByTitle(string Title, double Rating)
    {
        if(head == null) return;

        MovieNode temp = head;

        while(temp != null)
        {
            if(temp.MovieTitle == Title)
            {
                temp.Rating = Rating;
                Console.WriteLine("Ratings Updated Successfully!");
                return;
            }
            temp = temp.next;
        }

        Console.WriteLine("Movie Not Found!");
    }
}