using System;
using BankingSystem;
using ECommercePlatform;
using EmployeeManagementSystem;
using FoodDeliverySystem;
using HospitalManagementSystem;
using LibraryManagementSystem;
using RideApp = RideHailingApplication;
using RentalApp = VehicleRentalSystem;

internal class Program
{
    private static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("=== OOPS Advanced Questions Menu ===");
            Console.WriteLine("1. Banking System");
            Console.WriteLine("2. E-Commerce Platform");
            Console.WriteLine("3. Employee Management System");
            Console.WriteLine("4. Food Delivery System");
            Console.WriteLine("5. Hospital Management System");
            Console.WriteLine("6. Library Management System");
            Console.WriteLine("7. Ride Hailing Application");
            Console.WriteLine("8. Vehicle Rental System");
            Console.WriteLine("9. Exit");
            Console.Write("Choose a problem to run (1-9): ");

            if (!int.TryParse(Console.ReadLine(), out int choice))
            {
                Console.WriteLine("Invalid choice. Press any key to try again.");
                Console.ReadKey();
                continue;
            }

            Console.Clear();
            switch (choice)
            {
                case 1:
                    RunBankingSystem();
                    break;
                case 2:
                    RunECommercePlatform();
                    break;
                case 3:
                    RunEmployeeManagementSystem();
                    break;
                case 4:
                    RunFoodDeliverySystem();
                    break;
                case 5:
                    RunHospitalManagementSystem();
                    break;
                case 6:
                    RunLibraryManagementSystem();
                    break;
                case 7:
                    RunRideHailingApplication();
                    break;
                case 8:
                    RunVehicleRentalSystem();
                    break;
                case 9:
                    return;
                default:
                    Console.WriteLine("Please choose a valid option.");
                    break;
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to return to the menu.");
            Console.ReadKey();
        }
    }

    private static void RunBankingSystem()
    {
        Console.WriteLine("--- Banking System ---");
        Console.Write("Enter savings account holder name: ");
        var savingsName = Console.ReadLine() ?? "Savings Customer";
        var savings = new SavingsAccount("S001", savingsName, 10000);

        Console.Write("Enter current account holder name: ");
        var currentName = Console.ReadLine() ?? "Current Customer";
        var current = new CurrentAccount("C001", currentName, 25000);

        Console.WriteLine();
        savings.DisplayAccountDetails();
        Console.WriteLine();
        current.DisplayAccountDetails();
    }

    private static void RunECommercePlatform()
    {
        Console.WriteLine("--- E-Commerce Platform ---");

        new Electronics("E001", "Smartphone", 15000, 0.1, 0.12);
        new Clothing("C001", "T-Shirt", 800, 0.15, 0.08);
        new Groceries("G001", "Rice", 2500, 0.05);

        Product.DisplayFinalPrice();
    }

    private static void RunEmployeeManagementSystem()
    {
        Console.WriteLine("--- Employee Management System ---");

        var fullTime = new FullTimeEmployee("E001", "Alice", 50000, "Finance");
        fullTime.DisplayFullTimeEmployeeDetails();
        fullTime.CalculateSalary();

        Console.WriteLine();
        Console.Write("Enter working hours for part-time employee: ");
        var hours = ReadInt(defaultValue: 40);

        var partTime = new PartTimeEmployee("E002", "Bob", 200, "Support", hours);
        partTime.DisplayDetails();
        Console.WriteLine(partTime.GetDepartmentDetails());
        partTime.CalculateSalary();
    }

    private static void RunFoodDeliverySystem()
    {
        Console.WriteLine("--- Food Delivery System ---");

        var veg = new VegItem("Paneer Wrap", 200, 2, 40, 0.1);
        var nonVeg = new NonVegItem("Chicken Pizza", 450, 1, 60, 0.05);

        veg.GetItemDetails();
        Console.WriteLine(veg.GetDiscountDetails());
        Console.WriteLine($"Total Price: {veg.CalculateTotalPrice():C}");
        Console.WriteLine();

        nonVeg.GetItemDetails();
        Console.WriteLine(nonVeg.GetDiscountDetails());
        Console.WriteLine($"Total Price: {nonVeg.CalculateTotalPrice():C}");
    }

    private static void RunHospitalManagementSystem()
    {
        Console.WriteLine("--- Hospital Management System ---");

        var inpatient = new InPatient("P001", "Anita", 35, 5, 1500, 3000);
        inpatient.AddRecord("Fever", "No prior conditions");
        inpatient.DisplayPatientDetails();
        Console.WriteLine(inpatient.ViewRecords());
        Console.WriteLine($"Total Bill: {inpatient.CalculateBill():C}");

        Console.WriteLine();
        var outpatient = new OutPatient("P002", "Rohit", 28, 800, 1200);
        outpatient.AddRecord("Cold", "Allergic to penicillin");
        outpatient.DisplayPatientDetails();
        Console.WriteLine(outpatient.ViewRecords());
        Console.WriteLine($"Total Bill: {outpatient.CalculateBill():C}");
    }

    private static void RunLibraryManagementSystem()
    {
        Console.WriteLine("--- Library Management System ---");

        var book = new Book("B001", "C# Fundamentals", "Jon Skeet");
        var magazine = new Magazine("M001", "Tech Today", "Jane Doe");
        var dvd = new DVD("D001", "OOPS Concepts", "Studio Learn");

        book.GetItemDetails();
        Console.WriteLine($"Loan Duration: {book.GetLoanDuration()} days");
        Console.WriteLine($"Available: {book.CheckAvailability()}");
        book.ReserveItem();
        Console.WriteLine($"Available after reservation: {book.CheckAvailability()}");

        Console.WriteLine();
        magazine.GetItemDetails();
        Console.WriteLine($"Loan Duration: {magazine.GetLoanDuration()} days");
        Console.WriteLine($"Available: {magazine.CheckAvailability()}");

        Console.WriteLine();
        dvd.GetItemDetails();
        Console.WriteLine($"Loan Duration: {dvd.GetLoanDuration()} days");
        Console.WriteLine($"Available: {dvd.CheckAvailability()}");
    }

    private static void RunRideHailingApplication()
    {
        Console.WriteLine("--- Ride Hailing Application ---");

        var car = new RideApp.Car("R001", "Sam", 20, 50);
        var bike = new RideApp.Bike("R002", "Nina", 10, 15);
        var auto = new RideApp.Auto("R003", "Amit", 12, 30);

        Console.Write("Enter trip distance in km: ");
        var distance = ReadDouble(defaultValue: 5);

        car.UpdateLocation("Downtown");
        bike.UpdateLocation("Central Park");
        auto.UpdateLocation("Railway Station");

        car.GetVehicleDetails();
        Console.WriteLine($"Location: {car.GetCurrentLocation()}");
        Console.WriteLine($"Fare: {car.CalculateFare(distance):C}");
        Console.WriteLine();

        bike.GetVehicleDetails();
        Console.WriteLine($"Location: {bike.GetCurrentLocation()}");
        Console.WriteLine($"Fare: {bike.CalculateFare(distance):C}");
        Console.WriteLine();

        auto.GetVehicleDetails();
        Console.WriteLine($"Location: {auto.GetCurrentLocation()}");
        Console.WriteLine($"Fare: {auto.CalculateFare(distance):C}");
    }

    private static void RunVehicleRentalSystem()
    {
        Console.WriteLine("--- Vehicle Rental System ---");

        new RentalApp.Car("V001", "Sedan", 2500, 10000, 0.02, 12);
        new RentalApp.Bike("V002", "Scooter", 800, 3000, 0.015, 6);
        new RentalApp.Truck("V003", "Transport Truck", 5000);

        Console.Write("Enter rental duration in days: ");
        var days = ReadInt(defaultValue: 3);

        var truck = new RentalApp.Truck("V003", "Transport Truck", 5000);

        var dummy = new RentalApp.Car();
        dummy.DisplayAllDetails(days);
    }

    private static int ReadInt(int defaultValue)
    {
        if (int.TryParse(Console.ReadLine(), out int result))
        {
            return result;
        }

        return defaultValue;
    }

    private static double ReadDouble(double defaultValue)
    {
        if (double.TryParse(Console.ReadLine(), out double result))
        {
            return result;
        }

        return defaultValue;
    }
}

