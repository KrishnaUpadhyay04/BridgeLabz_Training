// Console.WriteLine("Hello, World!");

Console.WriteLine("Choose the Operation you want to execute");
Console.WriteLine("1. Display Employee Details");
Console.WriteLine("2. Compute Area and Perimeter of a circle");
Console.WriteLine("3. Handle Book Details");
Console.WriteLine("0. Exit Program");

while(true)
{
    Console.Write("Enter your choice: ");
    int choice = Convert.ToInt32(Console.ReadLine());

    if(choice == 1)
    {
        string name;
        int id;
        double salary;

        Console.Write("Enter the name of the employee: ");
        name = Console.ReadLine() ?? "";

        Console.Write("Enter the id of the employee: ");
        id = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the salary of the employee: ");
        salary = Convert.ToDouble(Console.ReadLine());

        Employee employee = new(name, id, salary);

        employee.DisplayDetails();
    }

    else if(choice == 2)
    {
        Console.Write("Enter the radius: ");
        double radius = Convert.ToDouble(Console.ReadLine());

        Circle circle = new(radius);

        circle.DisplayArea();
        circle.DisplayPerimeter();
    }

    else if(choice == 3)
    {
        Console.Write("Enter the title of the book: ");
        string title = Console.ReadLine() ?? "";

        Console.Write("Enter the name of the author: ");
        string author = Console.ReadLine() ?? "";

        Console.Write("Enter the price of the book: ");
        double price = Convert.ToDouble(Console.ReadLine());

        Book book = new Book(title, author, price);

        book.DisplayDetails();
    }

    else if(choice == 0) {
        Console.WriteLine("Exiting...");
        Environment.Exit(0);
    }
    else Console.WriteLine("Invalid choice!");
}
