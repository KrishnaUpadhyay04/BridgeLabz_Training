public static class Question6
{
    public static void Run()
    {
        Console.Write("Enter Amar's age: ");
        int amarAge = int.Parse(Console.ReadLine()!);
        Console.Write("Enter Amar's height: ");
        double amarHeight = double.Parse(Console.ReadLine()!);

        Console.Write("Enter Akbar's age: ");
        int akbarAge = int.Parse(Console.ReadLine()!);
        Console.Write("Enter Akbar's height: ");
        double akbarHeight = double.Parse(Console.ReadLine()!);

        Console.Write("Enter Anthony's age: ");
        int anthonyAge = int.Parse(Console.ReadLine()!);
        Console.Write("Enter Anthony's height: ");
        double anthonyHeight = double.Parse(Console.ReadLine()!);

        int youngestAge = Math.Min(amarAge, Math.Min(akbarAge, anthonyAge));
        double tallestHeight = Math.Max(amarHeight, Math.Max(akbarHeight, anthonyHeight));

        if (youngestAge == amarAge)
        {
            Console.WriteLine("Youngest friend: Amar");
        }
        else if (youngestAge == akbarAge)
        {
            Console.WriteLine("Youngest friend: Akbar");
        }
        else
        {
            Console.WriteLine("Youngest friend: Anthony");
        }

        if (tallestHeight == amarHeight)
        {
            Console.WriteLine("Tallest friend: Amar");
        }
        else if (tallestHeight == akbarHeight)
        {
            Console.WriteLine("Tallest friend: Akbar");
        }
        else
        {
            Console.WriteLine("Tallest friend: Anthony");
        }
    }
}
