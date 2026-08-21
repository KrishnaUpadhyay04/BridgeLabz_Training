namespace CabBooking;

class Program
{
    static void Main()
    {

        Customer customer1 = new Customer("Krishna", 101);
        Customer customer2 = new Customer("Rahul", 102);



        Car car = new Car("CAR101", "Petrol", null);

        Bike bike = new Bike("BIKE101", "Electric", null);



        Driver driver1 = new Driver("Amit", car);

        Driver driver2 = new Driver("Rohit", bike);



        Console.WriteLine("Vehicle Details");

        car.DisplayVehicleDetails();

        Console.WriteLine();

        bike.DisplayVehicleDetails();

        Console.WriteLine();

        Vehicle vehicle1 = car;
        Vehicle vehicle2 = bike;

        Console.WriteLine($"Car seats: {vehicle1.AvailableSeats()}");

        Console.WriteLine($"Bike seats: {vehicle2.AvailableSeats()}");



        Console.WriteLine();
        Console.WriteLine("Ride Request");

        customer1.CabRequest(driver1, "Chandigarh", "Mohali", 350, 2);

        Console.WriteLine("Ride requested successfully.");


        Console.WriteLine();
        Console.WriteLine("Accepting Ride");

        driver1.AcceptRide();


        Console.WriteLine();
        Console.WriteLine("Customer Rides");

        customer1.RidesDetails();


        Console.WriteLine();
        Console.WriteLine("Driver Rides");

        driver1.RidesDetails();


        Console.WriteLine();
        Console.WriteLine("Payment");

        IPayment payment;

        payment = new CashPayment();

        payment.PayAmount(350);

        payment = new UPI();

        payment.PayAmount(350);

        Console.WriteLine();
        Console.WriteLine("RATING");

        Rating rating = new Rating(driver1, "Very good driver", 9);

        driver1.AddRating(rating);

        Console.WriteLine("Rating added successfully.");
    }
}