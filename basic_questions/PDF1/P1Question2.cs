using System;

class P1Question2
{
    public static void Solution()
    {
        int MathMarks = 94;
        int PhysicsMarks = 95;
        int ChemistryMarks = 96;

        double averageMarks = (MathMarks + PhysicsMarks + ChemistryMarks) / 3.0;

        Console.WriteLine($"Sam's average marks in PCM is {averageMarks}");
    }
}