/*
3. Develop  a  c#  program  to  list  all  substrings  in  a  given  string
*/

using System;

class Lab3
{
    static void Main()
    {
        string str;
        Console.WriteLine("Enter a string:");
        str = Console.ReadLine();
        Console.WriteLine("All substrings in a given string are:");
        for (int i = 0; i < str.Length; i++)
        {
            for (int j = 1; j <= str.Length - i; j++)
            {
                Console.WriteLine(str.Substring(i, j));
            }
        }
        Console.WriteLine("All substrings in a given string are printed.");
    }
}