public static class Question1
{
    public static void Run()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine()!);

        bool isDivisibleBy5 = number % 5 == 0;
        Console.WriteLine($"Is the number {number} divisible by 5? {isDivisibleBy5}");
    }
}
