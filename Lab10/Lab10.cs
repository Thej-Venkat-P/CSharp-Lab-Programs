/* 
10. Develop a C# program to create a class named shape. Create three subclasses namely: circle,triangle 
and square, each class has two member functions named draw() and erase(). Demonstrate 
polymorphism concepts by developing suitable methods, defining member data and main program
*/

using System;

class Shape
{
    public virtual void Draw()
    {
        Console.WriteLine("Drawing Shape");
    }
    public virtual void Erase()
    {
        Console.WriteLine("Erasing Shape");
    }
}

class Circle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing Circle");
    }
    public override void Erase()
    {
        Console.WriteLine("Erasing Circle");
    }
}

class Triangle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing Triangle");
    }
    public override void Erase()
    {
        Console.WriteLine("Erasing Triangle");
    }
}

class Square : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing Square");
    }
    public override void Erase()
    {
        Console.WriteLine("Erasing Square");
    }
}

class Lab10
{ 
    static void Main() 
    { 
        // Demonstrate polymorphism 
       // Create an array of shapes 
        Shape[] shapes = new Shape[3]; 
 
        // Instantiate objects of different subclasses 
        shapes[0] = new Circle(); 
        shapes[1] = new Triangle(); 
        shapes[2] = new Square(); 
 
        // Iterate through the array and call Draw and Erase methods 
        foreach (Shape shape in shapes) 
        { 
            shape.Draw(); 
            shape.Erase(); 
            Console.WriteLine(); // Add a newline for better readability 
        } 
    } 
} 