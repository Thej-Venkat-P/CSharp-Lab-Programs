/*
11. Develop a c# program to create an abstract class shape with abstract method  calculate Area() and 
calculate Perimeter(). Create subclasses Circle and Triangle that extend the shape class and implement 
the respective methods to calculate the area and perimeter of each shape.
*/

using System;

public abstract class Shape
{
    public abstract double CalculateArea();
    public abstract double CalculatePerimeter();
}

public class Circle : Shape
{
    private double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public override double CalculateArea()
    {
        return Math.PI * radius * radius;
    }

    public override double CalculatePerimeter()
    {
        return 2 * Math.PI * radius;
    }
}

public class Triangle : Shape
{
    private double side1, side2, side3;

    public Triangle(double side1, double side2, double side3)
    {
        this.side1 = side1;
        this.side2 = side2;
        this.side3 = side3;
    }

    public override double CalculateArea()
    {
        double s = (side1 + side2 + side3) / 2;
        return Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3));
    }

    public override double CalculatePerimeter()
    {
        return side1 + side2 + side3;
    }
}

public class Lab11
{
    public static void Main(string[] args)
    {
        Circle circle = new Circle(5);
        Console.WriteLine("Circle Area: " + circle.CalculateArea());
        Console.WriteLine("Circle Perimeter: " + circle.CalculatePerimeter());

        Triangle triangle = new Triangle(3, 4, 5);
        Console.WriteLine("Triangle Area: " + triangle.CalculateArea());
        Console.WriteLine("Triangle Perimeter: " + triangle.CalculatePerimeter());
    }
}

// Output:

/*
Circle Area: 78.53981633974483
Circle Perimeter: 31.41592653589793
Triangle Area: 6
Triangle Perimeter: 12
*/