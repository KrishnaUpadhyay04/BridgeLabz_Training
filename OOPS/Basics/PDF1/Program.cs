using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("========== MENU ==========");
        Console.WriteLine("1. Bank Account System");
        Console.WriteLine("2. Library Management System");
        Console.WriteLine("3. Employee Management System");
        Console.WriteLine("4. Shopping Cart System");
        Console.WriteLine("5. University Student Management");
        Console.WriteLine("6. Vehicle Registration System");
        Console.WriteLine("7. Hospital Management System");
        Console.Write("\nEnter your choice: ");

        int choice = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine();

        switch (choice)
        {
            case 1:
            {
                BankAccount account1 = new BankAccount("Krishna", "ACC101");
                BankAccount account2 = new BankAccount("Rahul", "ACC102");

                BankAccount.GetTotalAccounts();

                object obj = account1;

                if (obj is BankAccount account)
                {
                    account.DisplayAccountDetails();
                }

                break;
            }

            case 2:
            {
                Book book1 = new Book("Atomic Habits", "James Clear", "ISBN001");
                Book book2 = new Book("Clean Code", "Robert C. Martin", "ISBN002");

                Book.DisplayLibraryName();

                object obj = book1;

                if (obj is Book book)
                {
                    book.DisplayBookDetails();
                }

                break;
            }

            case 3:
            {
                Employee emp1 = new Employee("Krishna", "EMP101", "Software Engineer");
                Employee emp2 = new Employee("Rahul", "EMP102", "QA Engineer");

                Employee.DisplayTotalEmployees();

                object obj = emp1;

                if (obj is Employee employee)
                {
                    employee.DisplayEmployeeDetails();
                }

                break;
            }

            case 4:
            {
                Product product1 = new Product("Laptop", 75000, 2);
                Product product2 = new Product("Mouse", 1200, 3);

                Product.UpdateDiscount(0.20);

                object obj = product1;

                if (obj is Product product)
                {
                    product.DisplayProductDetails();
                }

                break;
            }

            case 5:
            {
                Student student1 = new Student("Krishna", 1234, 'A');
                Student student2 = new Student("Rahul", 222, 'B');

                Student.DisplayTotalStudents();

                object obj = student1;

                if (obj is Student student)
                {
                    student.DisplayStudentDetails();
                }

                break;
            }

            case 6:
            {
                Vehicle vehicle1 = new Vehicle("Krishna", "Car", "PB10AB1234");
                Vehicle vehicle2 = new Vehicle("Rahul", "Bike", "PB11CD5678");

                Vehicle.UpdateRegistrationFees(2500);

                object obj = vehicle1;

                if (obj is Vehicle vehicle)
                {
                    vehicle.DisplayVehicleDetails();
                }

                break;
            }

            case 7:
            {
                Patient patient1 = new Patient("Krishna", 21, "Fever", "PAT001");
                Patient patient2 = new Patient("Rahul", 25, "Typhoid", "PAT002");

                Patient.GetTotalPatients();

                object obj = patient1;

                if (obj is Patient patient)
                {
                    patient.DisplayDetails();
                }

                break;
            }

            default:
                Console.WriteLine("Invalid Choice!");
                break;
        }
    }
}