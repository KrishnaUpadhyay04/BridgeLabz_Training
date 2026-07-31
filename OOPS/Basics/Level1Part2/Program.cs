using System.Collections.Concurrent;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

Console.WriteLine("1. Product Inventory");
Console.WriteLine("2. Online Course Management");
Console.WriteLine("3. Vehicle Registeration");
Console.WriteLine("4. University Management System");
Console.WriteLine("5. Book Library System");
Console.WriteLine("6. Bank Account Management");
Console.WriteLine("7. Employee Records");
Console.WriteLine("0. Exit Program");

while(true)
{
    Console.Write("Enter your choice: ");
    int choice = Convert.ToInt32(Console.ReadLine());

    if(choice == 1)
    {
        Console.Write("Enter Name of Product: ");
        string name = Console.ReadLine() ?? "";

        Console.Write("\nEnter the Price of the Product: ");
        double price = Convert.ToDouble(Console.ReadLine());

        Product product = new Product(name, price);

        product.DisplayProductDetails();
        Product.DisplayTotalProducts();
    }

    else if(choice == 2)
    {
        Console.Write("Enter the Name of the Course: ");
        string name = Console.ReadLine() ?? "";

        Console.Write("\nEnter the Duration of the Course: ");
        string duration = Console.ReadLine() ?? "";

        Console.Write("\nEnter the Fees of the Course: ");
        double fees = Convert.ToInt32(Console.ReadLine());

        Course course = new Course(name, duration, fees);

        Console.Write("\nDo you want to change the name of the Institue: (y/n): ");
        char ch = Convert.ToChar(Console.ReadLine());
        if(ch == 'y' || ch == 'Y')
        {
            Console.WriteLine("Enter the updated name of the Institute: ");
            string institue = Console.ReadLine() ?? "";

            Course.UpdateInstituteName(institue);
        }

        course.DisplayCourseDetails();
    }

    else if(choice == 3)
    {
        Console.Write("Enter the name of the Owner: ");
        string name = Console.ReadLine() ?? "";

        Console.Write("\nEnter the Vehicle Type: ");
        string type = Console.ReadLine();

        Vehicle vehicle = new(name, type);

        Console.Write("\nDo you want to update Registeration Fee? (y/n): ");
        char ch = Convert.ToChar(Console.ReadLine());

        if(ch == 'y' || ch == 'Y')
        {
            Console.Write("\nEnter the new registerstion fee: ");
            double fee = Convert.ToDouble(Console.ReadLine());

            Vehicle.UpdateRegisterationFee(fee);
        }

        vehicle.DisplayVehicleDetails();
    }

    else if(choice == 4)
    {
        Console.Write("Enter Roll Number: ");
        string rollno = Console.ReadLine();

        Console.Write("\nEnter Name of the Student: ");
        string name = Console.ReadLine();

        Console.Write("\nEnter student's CGPA: ");
        double cgpa = Convert.ToDouble(Console.ReadLine());

        Student student = new(rollno, name, cgpa);

        Console.Write("Get CGPA: ");
        cgpa = student.GetCGPA();
        Console.WriteLine($"CGPA: {cgpa}");

        student.Display();

        Console.WriteLine("Creating PostGraduateStudent Object...");
        
        Console.Write("Enter Roll Number: ");
        rollno = Console.ReadLine();

        Console.Write("\nEnter Name of the Student: ");
        name = Console.ReadLine();

        Console.Write("\nEnter student's CGPA: ");
        cgpa = Convert.ToDouble(Console.ReadLine());

        Console.Write("\nEnter Specialization: ");
        string specialization = Console.ReadLine();

        PostGraduateStudents pgs = new(rollno, name, cgpa, specialization);

        pgs.DisplayPGStudent();
    }

    else if(choice == 5)
    {
        Console.Write("Enter the ISBN number: ");
        string isbn = Console.ReadLine();

        Console.Write("\nEnter the Title of the Book: ");
        string title = Console.ReadLine();

        Console.Write("\nEnter the name of the Author: ");
        string author = Console.ReadLine();

        Book book = new(isbn, title, author);

        Console.WriteLine("Getting Author's Name...");
        book.GetAuthorName();

        EBOOK ebook = new(isbn, title, author);
        ebook.DisplayEBook();
    }

    else if(choice == 6)
    {
        Console.Write("Enter Account Number: ");
        string accNumber = Console.ReadLine();

        Console.Write("\nEnter the name of the account holder: ");
        string accHolder = Console.ReadLine();

        Console.Write("\nEnter the balance amount: ");
        double balance = Convert.ToDouble(Console.ReadLine());

        BankAccount bankAccount = new(accNumber, accHolder, balance);

        SavingsAccount savingsAccount = new(accNumber, accHolder, balance);

        savingsAccount.DisplayAccountNumber();
        savingsAccount.DisplayAccountHolder();
    }

    else if(choice == 7)
    {
        Console.Write("Enter Employee Id: ");
        string empId = Console.ReadLine();

        Console.Write("\nEnter Department Name: ");
        string department = Console.ReadLine();

        Console.Write("\nEnter Employee's Salary: ");
        double salary = Convert.ToDouble(Console.ReadLine());

        Employee employee = new(empId, department, salary);

        employee.Display();

        Manager manager = new(empId, department, salary);

        manager.DisplayEmployeeID();
        manager.DisplayDepartment();
    }

    else if(choice == 0)
    {
        Console.WriteLine("Exiting...");
        Environment.Exit(0);
    }

    else Console.WriteLine("Invalid Choice! Try Again.");
}