public static class Question2
{
    public static void Run()
    {
        Console.Write("Enter an integer: ");
        int number = int.Parse(Console.ReadLine()!);
        int count = 0;
        int temp = number;

        while (temp != 0)
        {
            temp /= 10;
            count++;
        }

        Console.WriteLine($"Number of digits: {count}");
    }
}
