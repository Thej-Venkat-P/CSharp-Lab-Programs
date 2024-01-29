// 7. Develop a c# program to read a text file and copy the file contents to another text file

using System;
using System.IO;

class Lab7
{
    static void Main()
    {
        Console.Write("Enter the path of the source text file: ");
        string sourceFilePath = Console.ReadLine();

        Console.Write("Enter the path of the destination text file: ");
        string destinationFilePath = Console.ReadLine();

        // Read and copy the file contents 
        CopyFileContents(sourceFilePath, destinationFilePath);

        Console.WriteLine("File contents copied successfully!");

        /* Display the content */
        string fileContent = File.ReadAllText(destinationFilePath);
        Console.WriteLine("File Content:");
        Console.WriteLine(fileContent);
    }

    static void CopyFileContents(string sourceFilePath, string destinationFilePath)
    {
        try
        {
            // Read the contents of the source file 
            string fileContents = File.ReadAllText(sourceFilePath);

            // Write the contents to the destination file 
            File.WriteAllText(destinationFilePath, fileContents);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}
