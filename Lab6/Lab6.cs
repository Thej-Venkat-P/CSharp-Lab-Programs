/*
6. Develop a c# program to generate and print floyds triangle using jagged arrays 
*/

using System;

class Lab6
{
    static void Main()
    {
        Console.WriteLine("Enter number of rows:");
        int rows = Convert.ToInt32(Console.ReadLine());
        int[][] arr = new int[rows][];
        Floyd(arr, rows);
        printFloyd(arr, rows);
    }
    static void printFloyd(int[][] arr, int rows)
    {
        Console.WriteLine("Floyd's Triangle:");
        for (int i = 0; i < rows; i++)
        {
            for (int spaces = 0; spaces < rows - i - 1; spaces++)
                Console.Write(" ");
            for (int j = 0; j <= i; j++)
                Console.Write(arr[i][j] + " ");
            Console.WriteLine();
        }
    }

    static void Floyd(int[][] arr, int rows)
    {

        for (int i = 0; i < rows; i++)
        {
            int num = 1;
            arr[i] = new int[i + 1];
            for (int j = 0; j <= i; j++)
            {
                arr[i][j] = num++;
            }
        }
    }
}