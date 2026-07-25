public static class Question18
{
    public static void Run()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine()!);

        if (number >= 6 && number <= 9)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{number} * {i} = {number * i}");
            }
        }
        else
        {
            Console.WriteLine("Please enter a number between 6 and 9");
        }
    }
}
