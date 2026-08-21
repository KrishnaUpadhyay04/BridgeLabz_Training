namespace CabBooking;

class Rating
{
    Driver driver;
    string Comment;
    int Points;

    public Rating(Driver driver, string Comment, int Points)
    {
        this.driver = driver;
        this.Comment = Comment;
        this.Points = Points;
    }
}