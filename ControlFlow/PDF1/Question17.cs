public static class Question17
{
    public static void Run()
    {
        Console.Write("Enter salary: ");
        double salary = double.Parse(Console.ReadLine()!);

        Console.Write("Enter years of service: ");
        int yearsOfService = int.Parse(Console.ReadLine()!);

        if (yearsOfService > 5)
        {
            double bonus = salary * 0.05;
            Console.WriteLine($"Bonus amount: {bonus}");
        }
        else
        {
            Console.WriteLine("No bonus");
        }
    }
}
