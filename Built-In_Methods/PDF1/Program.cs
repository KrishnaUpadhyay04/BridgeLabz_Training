// Console.WriteLine("Hello, World!");

while(true)
{
    Console.Clear();
    Console.WriteLine("Methods Practice Programs");
    Console.WriteLine("1. TimeZones and DateTimeOffSet");
    Console.WriteLine("2. Date Arithmetic");
    Console.WriteLine("3. Date Formatting");
    Console.WriteLine("4. Date Comparision");
    Console.WriteLine("0. Exit");
    Console.Write("Chhose an option: ");

    string? choice = Console.ReadLine();

    switch(choice)
    {
        case "1": Question1.Solution(); break;
        case "2": Question2.Solution(); break;
        case "3": Question3.Solution(); break;
        case "4": Question4.Solution(); break;
        case "0": return;
        default: Console.WriteLine("Inavalid Option"); break;
    } 
}