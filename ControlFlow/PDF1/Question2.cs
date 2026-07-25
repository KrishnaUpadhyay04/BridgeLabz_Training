public static class Question2
{
    public static void Run()
    {
        Console.Write("Enter number1: ");
        int number1 = int.Parse(Console.ReadLine()!);

        Console.Write("Enter number2: ");
        int number2 = int.Parse(Console.ReadLine()!);

        Console.Write("Enter number3: ");
        int number3 = int.Parse(Console.ReadLine()!);

        bool isFirstSmallest = number1 < number2 && number1 < number3;
        Console.WriteLine($"Is the first number the smallest? {isFirstSmallest}");
    }
}
