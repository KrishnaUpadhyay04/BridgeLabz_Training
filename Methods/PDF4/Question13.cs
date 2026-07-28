using System;

public class Question13
{
    public static void Run()
    {
        Console.WriteLine("Question 13: Matrix operations");
        Console.Write("Enter rows: ");
        int rows = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter columns: ");
        int columns = Convert.ToInt32(Console.ReadLine());

        int[,] matrix = new int[rows, columns];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write($"Enter value at [{i},{j}]: ");
                matrix[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        Console.WriteLine("Matrix:");
        Program.PrintMatrix(matrix);
        Console.WriteLine($"Transpose:");
        Program.PrintMatrix(Program.TransposeMatrix(matrix));
        Console.WriteLine($"Sum of all elements: {Program.SumOfMatrix(matrix)}");
        Console.WriteLine($"Product of diagonal elements: {Program.ProductOfDiagonal(matrix)}");
    }
}
