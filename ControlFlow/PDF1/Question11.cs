public static class Question11
{
    public static void Run()
    {
        Console.Write("Enter a number (0 or negative to stop): ");
        double total = 0.0;

        while (true)
        {
            double input = double.Parse(Console.ReadLine()!);

            if (input <= 0)
            {
                break;
            }

            total += input;
            Console.Write("Enter a number (0 or negative to stop): ");
        }

        Console.WriteLine($"Total sum: {total}");
    }
}
