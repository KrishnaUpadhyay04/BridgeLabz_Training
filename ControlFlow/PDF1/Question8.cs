public static class Question8
{
    public static void Run()
    {
        Console.Write("Enter a number for countdown: ");
        int counter = int.Parse(Console.ReadLine()!);

        while (counter >= 1)
        {
            Console.WriteLine(counter);
            counter--;
        }
    }
}
