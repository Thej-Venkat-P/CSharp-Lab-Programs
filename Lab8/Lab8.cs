/*
8. Develop a c# program to implement stack with push and pop operations[Hint:Use class ,get/set 
properties, methods for push and pop and main method.
*/

using System;

class StackProgram
{
    static void Main()
    {
        Console.Write("Enter the size of the stack: ");
        int size = Convert.ToInt32(Console.ReadLine());
        Stack stack = new Stack(size);            // Create a stack 

        stack.Push(10);   // Push elements onto the stack 
        stack.Push(20);
        stack.Push(30);
        Console.WriteLine("Stack elements:");    // Display the stack 
        stack.Display();
        int poppedElement = stack.Pop();
        Console.WriteLine($"Popped element: {poppedElement}");
        poppedElement = stack.Pop();
        Console.WriteLine($"Popped element: {poppedElement}");
        stack.Pop();
        Console.WriteLine("Stack elements after popping:");
        stack.Display();
        stack.Push(40);
        stack.Display();

    }
}

public class Stack
{
    private int MaxSize;
    private int[] array;
    private int top;
    public Stack(int size)
    {
        MaxSize = size;
        array = new int[MaxSize];
        top = -1;
    }
    public bool IsEmpty
    {
        get { return top == -1; }
    }
    public bool IsFull
    {
        get { return top == MaxSize - 1; }
    }
    public int Top
    {
        get { return top; }
    }
    public void Push(int element)
    {
        if (IsFull)
        {
            Console.WriteLine($"Stack overflow! Cannot push {element}");
        }
        else
        {
            array[++top] = element;
            Console.WriteLine($"Pushed element: {element}");
        }
    }
    public int Pop()
    {
        if (IsEmpty)
        {
            Console.WriteLine("Stack underflow! Cannot pop from an empty stack.");
            return -1;
        }
        else
        {
            int poppedElement = array[top--];
            return poppedElement;
        }
    }
    public void Display()
    {
        if (IsEmpty)
        {
            Console.WriteLine("Stack is empty.");
        }
        else
        {
            for (int i = 0; i <= top; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
        }
    }
}