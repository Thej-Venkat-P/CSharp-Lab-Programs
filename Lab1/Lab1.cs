/*
1. Develop a c# program to simulate simple arithmetic calculator for Addition, Subtraction, 
Multiplication,  Division  and  Mod  operations.  Read  the  operator  and  operands  through 
console
*/

using System;

class Lab1
{
    public static void Main()
    {
        int num1, num2; float result = 0;
        char op;
        Console.WriteLine("Enter the first number:");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the second number:");
        num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the operator:");
        op = Convert.ToChar(Console.ReadLine());

        bool divideByZero = (op == '/' || op == '%') && num2 == 0;

        switch (op)
        {
            case '+':
                result = num1 + num2;
                break;
            case '-':
                result = num1 - num2;
                break;
            case '*':
                result = num1 * num2;
                break;
            case '/':
                if (divideByZero)
                {
                    Console.WriteLine("Cannot divide by zero");
                    break;
                }
                result = num1 / num2;
                break;
            case '%':
                if (divideByZero)
                {
                    Console.WriteLine("Cannot divide by zero");
                    break;
                }
                result = num1 % num2;
                break;
            default:
                Console.WriteLine("Invalid operator");
                break;
        }

        Console.WriteLine();
        if (!divideByZero)
        {
            Console.WriteLine("Result: {0} {1} {2} = {3}", num1, op, num2, result);
        }
    }
}