using System;
using BankAccount;
using SchoolSystem;
using RestaurauntManagement;
using VehicleManagementSystem;

Console.WriteLine("Starting Program...");

Console.WriteLine();
Console.WriteLine("Make your choice:");
Console.WriteLine("1. Library Management with Books and Author");
Console.WriteLine("2. Smart Home Devices");
Console.WriteLine("3. Online Retail Order Management");
Console.WriteLine("4. Educational Course Hierarchy");
Console.WriteLine("5. Bank Account Types");
Console.WriteLine("6. School System with Different Roles");
Console.WriteLine("7. Restaurant Management System with Hybrid Inheritance");
Console.WriteLine("8. Vehicle Management System");
Console.WriteLine("9. Run all examples");
Console.WriteLine("0. Exit");

while (true)
{

    Console.Write("Enter your choice: ");

    int choice = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine();

    switch (choice)
    {
        case 0:
            Console.WriteLine("Exiting...");
            return;
        case 1:
            RunLibraryManagement();
            break;
        case 2:
            RunSmartHomeDevices();
            break;
        case 3:
            RunOnlineRetailOrderManagement();
            break;
        case 4:
            RunEducationalCourseHierarchy();
            break;
        case 5:
            RunBankAccountTypes();
            break;
        case 6:
            RunSchoolSystemRoles();
            break;
        case 7:
            RunRestaurantManagement();
            break;
        case 8:
            RunVehicleManagement();
            break;
        case 9:
            RunLibraryManagement();
            RunSmartHomeDevices();
            RunOnlineRetailOrderManagement();
            RunEducationalCourseHierarchy();
            RunBankAccountTypes();
            RunSchoolSystemRoles();
            RunRestaurantManagement();
            RunVehicleManagement();
            break;
        default:
            Console.WriteLine("Please enter a valid option between 0 and 9.");
            break;
    }
}

static void RunLibraryManagement()
{
    Console.WriteLine("--- Library Management with Books and Author ---");
    Book book = new Book("The C# Handbook", 2024);
    Author author = new Author("The C# Handbook", 2024, "Krishna Upadhyay", "C# instructor and author");

    Console.WriteLine("Book:");
    book.DisplayInfo();
    Console.WriteLine("\nAuthor extends Book:");
    author.DisplayInfo();
}

static void RunSmartHomeDevices()
{
    Console.WriteLine("--- Smart Home Devices ---");
    Device device = new Device("DEV-1001", "Online");
    Thermostat thermostat = new Thermostat("TH-2002", "Active", "22°C");

    Console.WriteLine("General Device:");
    device.DisplayStatus();
    Console.WriteLine("\nThermostat extends Device:");
    thermostat.DisplayStatus();
}

static void RunOnlineRetailOrderManagement()
{
    Console.WriteLine("--- Online Retail Order Management ---");
    Order placed = new Order("ORD001", DateTime.Today);
    ShippedOrder shipped = new ShippedOrder("ORD002", DateTime.Today.AddDays(-2), "TRK12345");
    DeliveredOrder delivered = new DeliveredOrder("ORD003", DateTime.Today.AddDays(-5), "TRK54321", DateTime.Today.AddDays(-1));

    placed.DisplayDetails();
    Console.WriteLine();
    shipped.DisplayDetails();
    Console.WriteLine();
    delivered.DisplayDetails();
}

static void RunEducationalCourseHierarchy()
{
    Console.WriteLine("--- Educational Course Hierarchy ---");
    Course baseCourse = new Course("Programming Fundamentals", TimeSpan.FromHours(20));
    OnlineCourse onlineCourse = new OnlineCourse("Web Development", TimeSpan.FromHours(30), "Udemy", true);
    PaidOnlineCourse paidCourse = new PaidOnlineCourse("Advanced C#", TimeSpan.FromHours(40), "Pluralsight", false, 499.99, 50.0);

    baseCourse.DisplayCourseInfo();
    Console.WriteLine();
    onlineCourse.DisplayCourseInfo();
    Console.WriteLine();
    paidCourse.DisplayCourseInfo();
}

static void RunBankAccountTypes()
{
    Console.WriteLine("--- Bank Account Types ---");
    BankAccount.BankAccount bankAccount = new BankAccount.BankAccount("ACCT1001", 1500.00);
    BankAccount.SavingsAccount savings = new BankAccount.SavingsAccount("ACCT1002", 2500.00, 4.5);
    BankAccount.CheckingAccount checking = new BankAccount.CheckingAccount("ACCT1003", 3000.00, 1000.00);
    BankAccount.FixedDepositAccount fixedDeposit = new BankAccount.FixedDepositAccount("ACCT1004", 10000.00, 12);

    bankAccount.DisplayAccountType();
    bankAccount.DisplayDetails();
    Console.WriteLine();

    savings.DisplayAccountType();
    savings.DisplayDetails();
    Console.WriteLine();

    checking.DisplayAccountType();
    checking.DisplayDetails();
    Console.WriteLine();

    fixedDeposit.DisplayAccountType();
    fixedDeposit.DisplayDetails();
}

static void RunSchoolSystemRoles()
{
    Console.WriteLine("--- School System with Different Roles ---");
    Teacher teacher = new Teacher("Priya", 35, "Mathematics");
    Student student = new Student("Rohit", 16, "10th Grade");
    Staff staff = new Staff("Sunita", 42, "Morning Shift");

    teacher.DisplayRole();
    Console.WriteLine($"Name: {teacher.Name}, Age: {teacher.Age}, Subject: {teacher.Subject}");
    Console.WriteLine();

    student.DisplayRole();
    Console.WriteLine($"Name: {student.Name}, Age: {student.Age}, Grade: {student.Grade}");
    Console.WriteLine();

    staff.DisplayRole();
    Console.WriteLine($"Name: {staff.Name}, Age: {staff.Age}, Period: {staff.Period}");
}

static void RunRestaurantManagement()
{
    Console.WriteLine("--- Restaurant Management System with Hybrid Inheritance ---");
    Chef chef = new Chef("Arjun", 101, "Italian Cuisine");
    Waiter waiter = new Waiter("Meera", 102, 12);

    chef.DisplayDetails();
    chef.PerformDuties();
    Console.WriteLine();

    waiter.DisplayDetails();
    waiter.PerformDuties();
}

static void RunVehicleManagement()
{
    Console.WriteLine("--- Vehicle Management System ---");
    PetrolVehicle petrolVehicle = new PetrolVehicle(180, "Honda Civic");
    ElectricVehicle electricVehicle = new ElectricVehicle(160, "Tesla Model 3");

    petrolVehicle.DisplayDetails();
    petrolVehicle.Refuel();
    Console.WriteLine();

    electricVehicle.DisplayDetails();
    electricVehicle.Charge();
}