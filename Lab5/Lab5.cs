/*
5. Develop a C# program to generate and print pascal triangle using two dimensional array
*/

using System;

class Lab5
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the number of rows for Pascal's triangle:");
        int rows = Convert.ToInt32(Console.ReadLine());

        int[,] triangle = new int[rows,rows];

        for (int i = 0; i < rows; i++)
        {
            triangle[i,0] = 1;
            for (int j = 1; j <= i; j++)
            {
                triangle[i,j] = triangle[i - 1,j - 1] + triangle[i - 1,j];
            }
        }

        // Print Pascal's triangle in a triangle shape
        for (int i = 0; i < rows; i++)
        {
            // Print spaces to align the triangle
            for (int k = 0; k < rows - i - 1; k++)
            {
                Console.Write(" ");
            }

            // Print the values of the current row
            for (int j = 0; j <= i; j++)
            {
                Console.Write(triangle[i,j] + " ");
            }

            Console.WriteLine();
        }
    }
}

// Output:

/*
Enter the number of rows for Pascal's triangle:
5
    1
   1 1
  1 2 1
 1 3 3 1
1 4 6 4 1
*/

/*
Enter the number of rows for Pascal's triangle:
6
     1        
    1 1       
   1 2 1      
  1 3 3 1     
 1 4 6 4 1    
1 5 10 10 5 1 
*/