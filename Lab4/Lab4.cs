// 4. Develop C# program to demonstrate division by zero and index out of range exceptions

using System;

class Lab4
{
    static void Main()
    {
        int num1, num2, result; bool flag = false;
        try
        {
            Console.WriteLine("Enter two numbers to Divide:");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            result = num1 / num2;
            Console.WriteLine("Result of division is: {0} ", result);

            Console.WriteLine("\nEnter the Length of Array:");
            int arrLength = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[arrLength];
            Console.WriteLine("Enter index of array element:");
            int index = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Value at index {index} is: {arr[index]} ");
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine($"DivideByZeroException: {e.Message}");
            flag = true;
        }
        catch (IndexOutOfRangeException e)
        {
            Console.WriteLine($"IndexOutOfRangeException: {e.Message}");
            flag = true;
        }
        catch (Exception e)
        {
            Console.WriteLine($"Exception: {e.Message}");
            flag = true;
        }
        finally
        {
            Console.WriteLine("\nError Occured : " + flag);
        }
    }
}
