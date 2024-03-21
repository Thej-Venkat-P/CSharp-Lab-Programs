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
        stack.Size = 3;
        stack.Push(30);
        stack.Display();
        stack.Push(40);

        int poppedElement = stack.Pop();
        Console.WriteLine($"Popped element: {poppedElement}");
        poppedElement = stack.Pop();
        Console.WriteLine($"Popped element: {poppedElement}");
        stack.Pop();
        stack.Display();
        stack.Pop();

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
     public int Size{
        get { return MaxSize; }
        set { 
            if(value > 0 && value > MaxSize){
                MaxSize = value;
                Console.WriteLine("Size has been resized to " + value);
                int[] tempArray = new int[value];
                for(int i = 0; i < array.Length; i++){
                    tempArray[i] = array[i];
                }
                this.array = tempArray;
            }
            else{
                Console.WriteLine("Size cannot be less than the current size.");
            }
        }
    }
}

// Output:
/*
Enter the size of the stack: 2
Pushed element: 10
Pushed element: 20
Size has been resized to 3
Pushed element: 30
10 20 30 
Stack overflow! Cannot push 40
Popped element: 30
Popped element: 20
Stack is empty.
Stack underflow! Cannot pop from an empty stack.
*/