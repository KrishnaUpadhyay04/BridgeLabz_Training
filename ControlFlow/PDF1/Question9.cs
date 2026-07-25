public static class Question9
{
    public static void Run()
    {
        Console.Write("Enter a number for countdown: ");
        int counter = int.Parse(Console.ReadLine()!);

        for (int i = counter; i >= 1; i--)
        {
            Console.WriteLine(i);
        }
    }
}
