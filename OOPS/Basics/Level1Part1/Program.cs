using System.Linq.Expressions;

Console.WriteLine("1. Book Class");
Console.WriteLine("2. Circle Class");
Console.WriteLine("3. Person Class");
Console.WriteLine("4. Hotel Booking System");
Console.WriteLine("5. Library Book System");
Console.WriteLine("6. Car Rental System");
Console.WriteLine("0. Exit");

while(true)
{
    Console.Write("Enter your choice: ");
    int choice = Convert.ToInt32(Console.ReadLine());

    if(choice == 1)
    {
        Book B = new();
        B.DisplayDetails();
    }

    else if(choice == 2)
    {
        Circle circle = new();
        circle.Display();
    }

    else if(choice == 3)
    {
        Person person = new("Krishna", 21, "Male");
        Person person2 = (person);
        person2.Display();
    }

    else if(choice == 4)
    {
        HotelBooking hotelBooking = new("Krishna", "Deluxe", 3);
        hotelBooking.Display();
    }

    else if(choice == 5)
    {
        Library library = new Library("The Jungle Book", "Krishna", 25.50, 3);
        library.BorrowBook();
    }

    else if(choice == 6)
    {
        Car car = new("Krishna", "Audi A5", 4);
        car.DisplayFees();
    }

    else Environment.Exit(0);
}