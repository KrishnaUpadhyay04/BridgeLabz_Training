public static class Question5
{
    public static void Run()
    {
        Console.Write("Enter age: ");
        int age = int.Parse(Console.ReadLine()!);

        if (age >= 18)
        {
            Console.WriteLine($"The person's age is {age} and can vote.");
        }
        else
        {
            Console.WriteLine($"The person's age is {age} and cannot vote.");
        }
    }
}
