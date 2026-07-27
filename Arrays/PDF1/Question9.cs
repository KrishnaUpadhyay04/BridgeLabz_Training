using System;
using System.Runtime.InteropServices;

class Question9
{
    public static void Solution()
    {
        Console.WriteLine("Enter the number of rows: ");
        int row = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the number of columns: ");
        int col = Convert.ToInt32(Console.ReadLine());


        int[,] matrix = new int[row, col];

        Console.WriteLine("Enter the numbers: ");
        for(int i = 0; i < row; i++)
        {
            for(int j = 0; j < col; j++)
            {
                matrix[i,j] = Convert.ToInt16(Console.ReadLine());
            }
        }

        Console.WriteLine("2D Array is formed as follows: ");

        for(int i = 0; i < row; i++)
        {
            for(int j = 0; j < col; j++)
            {
                Console.Write(matrix[i,j] + " ");
            }
            Console.WriteLine();
        }

        int[] arr = new int[row * col];

        Console.WriteLine("Compressing 2D array to 1D \nNew Array: ");

        int idx = 0;
        for(int i = 0; i < row; i++)
        {
            for(int j = 0; j < col; j++)
            {
                arr[idx++] = matrix[i, j];
            }
        }
        foreach(int num in arr) Console.Write(num + " ");
    }
}