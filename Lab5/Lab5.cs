/*
5. Develop a C# program to generate and print pascal triangle using two dimensional array
*/

using System;

class Lab5
{
    static void Main()
    {
        int rows, cols;
        Console.WriteLine("Enter number of rows:");
        rows = Convert.ToInt32(Console.ReadLine());
        cols = rows * 2 - 1;
        int[,] arr = new int[rows, cols];

        arr[0, rows - 1] = 1;
        for (int i = 1; i < rows; i++)
        {
            for (int j = 1; j < cols - 1; j++)
            {
                arr[i, j] = arr[i - 1, j - 1] + arr[i - 1, j + 1];
            }
        }
        arr[rows - 1, 0] = arr[rows - 1, cols - 1] = 1;

        Console.WriteLine("Pascal Triangle:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
                if (arr[i, j] != 0)
                    Console.Write(arr[i, j] + " ");
                else
                    Console.Write("  ");
            Console.WriteLine();
        }
    }
}