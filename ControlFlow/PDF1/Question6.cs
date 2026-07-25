public static class Question6
{
    public static void Run()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine()!);

        if (number > 0)
        {
            Console.WriteLine("positive");
        }
        else if (number < 0)
        {
            Console.WriteLine("negative");
        }
        else
        {
            Console.WriteLine("zero");
        }
    }
}
