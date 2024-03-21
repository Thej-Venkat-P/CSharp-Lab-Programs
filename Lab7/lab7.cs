// 7. Develop a c# program to read a text file and copy the file contents to another text file

using System;
using System.IO;

class Lab7
{
    static void Main()
    {
        try
        {
            Console.Write("Enter the path of the source text file: ");
            string sourceFilePath = Console.ReadLine();

            Console.Write("Enter the path of the destination text file: ");
            string destinationFilePath = Console.ReadLine();

            // Read the contents of the source file 
            string fileContents = File.ReadAllText(sourceFilePath);

            // Write the contents to the destination file 
            File.WriteAllText(destinationFilePath, fileContents);

            Console.WriteLine("File contents copied successfully!");

            /* Display the content */
            string fileContent = File.ReadAllText(destinationFilePath);
            Console.WriteLine("File Content at Destination:");
            Console.WriteLine(fileContent);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}

// Output:

/*
Enter the path of the source text file: a.txt
Enter the path of the destination text file: b.txt
File contents copied successfully!
File Content at Destination:
This is a.txt file.
Hello This is Example Text.

*/

/*
Enter the path of the source text file: a.txt
Enter the path of the destination text file: c.txt
File contents copied successfully!
File Content at Destination:      
This is a.txt file.
Hello This is Example Text.
Transfer this text to c.txt file.
*/