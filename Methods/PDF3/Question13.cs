using System;

public class Question13
{
    public static void Run()
    {
        Console.WriteLine("Question 13: Matrix operations");
        int rows = 2;
        int cols = 2;
        int[,] matrixA = Program.CreateRandomMatrix(rows, cols);
        int[,] matrixB = Program.CreateRandomMatrix(rows, cols);

        Program.DisplayMatrix(matrixA, "Matrix A");
        Program.DisplayMatrix(matrixB, "Matrix B");

        Program.DisplayMatrix(Program.AddMatrices(matrixA, matrixB), "Addition");
        Program.DisplayMatrix(Program.SubtractMatrices(matrixA, matrixB), "Subtraction");
        Program.DisplayMatrix(Program.MultiplyMatrices(matrixA, matrixB), "Multiplication");
        Program.DisplayMatrix(Program.TransposeMatrix(matrixA), "Transpose");

        Console.WriteLine($"Determinant 2x2 A: {Program.Determinant2x2(matrixA)}");
        Console.WriteLine($"Determinant 2x2 B: {Program.Determinant2x2(matrixB)}");
        Console.WriteLine($"Inverse 2x2 A: {Program.Inverse2x2(matrixA)}");
    }
}
