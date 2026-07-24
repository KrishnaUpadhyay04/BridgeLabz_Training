using System;

class SumOf2DMatrix
{
    public static void Solution()
    {
        Console.WriteLine("Enter the number of rows: ");
        int rows = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the number of columns: ");
        int cols = Convert.ToInt32(Console.ReadLine());

        int[,] matrix = new int[rows, cols];

        for(int i = 0; i < rows; i++)
        {
            for(int j = 0; j < cols; j++)
            {
                matrix[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        int sum = 0;

        foreach(var num in matrix) {
            sum += num;
        }

        Console.WriteLine("Sum of 2D Matrix: " + sum);

        Console.WriteLine("The 2D Matrix is as follows: ");

        for(int i = 0; i < rows; i++)
        {
            for(int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}