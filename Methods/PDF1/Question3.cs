using System;

public class Question3
{
    public static void Run()
    {
        Console.WriteLine("Question 3: Handshakes (alternate version)");
        Console.Write("Enter number of students: ");
        int numberOfStudents = Convert.ToInt32(Console.ReadLine());

        int handshakes = Program.CalculateHandshakes(numberOfStudents);
        Console.WriteLine($"The number of possible handshakes is {handshakes}");
    }
}
