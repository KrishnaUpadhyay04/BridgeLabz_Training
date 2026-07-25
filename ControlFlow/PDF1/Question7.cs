public static class Question7
{
    public static void Run()
    {
        Console.Write("Enter month: ");
        int month = int.Parse(Console.ReadLine()!);

        Console.Write("Enter day: ");
        int day = int.Parse(Console.ReadLine()!);

        bool isSpring = (month == 3 && day >= 20) || (month > 3 && month < 6) || (month == 6 && day <= 20);

        if (isSpring)
        {
            Console.WriteLine("Its a Spring Season");
        }
        else
        {
            Console.WriteLine("Not a Spring Season");
        }
    }
}
