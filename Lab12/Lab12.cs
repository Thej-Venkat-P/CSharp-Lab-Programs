/*
12.  Develop  a  C#  program  to  create  an  interface  Resizable  with  methods  reizeWidth(int  width)  and 
resizeHeight(int height) that allow an object to be resized. Create a class Rectangle that implements the 
Resizable interface and implements the resize methods.
*/

using System;

public interface Resizable
{
    void ResizeWidth(int width);
    void ResizeHeight(int height);
}

public class Rectangle : Resizable
{
    private int width;
    private int height;

    public Rectangle(int width, int height)
    {
        this.width = width;
        this.height = height;
    }

    public void ResizeWidth(int width)
    {
        if(width > 0){
            this.width = width;
            Console.WriteLine("Width has been resized to " + width);
        }
        else{
            Console.WriteLine("Width cannot be negative");
        }
    }

    public void ResizeHeight(int height)
    {
        if(height > 0){
            this.height = height;
            Console.WriteLine("Height has been resized to " + height);
        }
        else{
            Console.WriteLine("Height cannot be negative");
        }
    }

    public void Display()
    {
        Console.WriteLine("Width: " + this.width);
        Console.WriteLine("Height: " + this.height);
    }
}

public class Lab12
{
    public static void Main(string[] args)
    {
        Rectangle r = new Rectangle(10, 20);
        Console.WriteLine("Initial dimensions:");
        r.Display();
        r.ResizeWidth(15);
        r.ResizeHeight(25);
        Console.WriteLine("Updated dimensions:");
        r.Display();
    }
}

// Output:

/*
Initial dimensions:
Width: 10
Height: 20
Width has been resized to 15 
Height has been resized to 25
Updated dimensions:
Width: 15
Height: 25
*/