public static class Question8
{
    public static void Run()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine()!);

        Console.WriteLine($"Power of {number}:");
        int result = 1;

        for (int i = 1; i <= number; i++)
        {
            result *= number;
        }

        Console.WriteLine(result);
    }
}
