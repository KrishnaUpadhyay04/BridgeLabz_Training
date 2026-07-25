public static class Question10
{
    public static void Run()
    {
        double total = 0.0;
        double input;

        while (true)
        {
            Console.Write("Enter a number (0 to stop): ");
            input = double.Parse(Console.ReadLine()!);

            if (input == 0)
            {
                break;
            }

            total += input;
        }

        Console.WriteLine($"Total sum: {total}");
    }
}
