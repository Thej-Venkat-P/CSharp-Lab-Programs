/*
6. Develop a c# program to generate and print floyds triangle using jagged arrays 
*/

using System;

class Lab6
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the number of rows for Floyd's Triangle:");
        int rows = Convert.ToInt32(Console.ReadLine());

        int[][] FloydsTriangle = new int[rows][];

        // Generate Floyd's Triangle
        int count = 1;
        for (int i = 0; i < rows; i++)
        {
            FloydsTriangle[i] = new int[i + 1]; // Jagged array : each row has different number of columns
            for (int j = 0; j <= i; j++)
            {
                FloydsTriangle[i][j] = count;
                count++;
            }
        }

        // Print Floyd's Triangle
        Console.WriteLine("Floyd's Triangle:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                Console.Write(FloydsTriangle[i][j] + " ");
            }
            Console.WriteLine();
        }
    }
}

// Output:

/*
Enter the number of rows for Floyd's Triangle:
6
Floyd's Triangle: 
1 
2 3 
4 5 6 
7 8 9 10 
11 12 13 14 15    
16 17 18 19 20 21 
*/

/*
Enter the number of rows for Floyd's Triangle:
4
Floyd's Triangle:
1 
2 3 
4 5 6 
7 8 9 10 
*/