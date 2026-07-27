using System;

public class Question2
{
    public static void Run()
    {
        Console.WriteLine("Question 2: Handshakes");
        Console.Write("Enter number of students: ");
        int numberOfStudents = Convert.ToInt32(Console.ReadLine());

        int handshakes = Program.CalculateHandshakes(numberOfStudents);
        Console.WriteLine($"The maximum number of handshakes is {handshakes}");
    }
}
