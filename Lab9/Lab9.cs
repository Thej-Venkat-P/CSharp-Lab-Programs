/*
9.Design a class complex  with data members, constructor and method for  overloading a  binary 
operator '+'. Develop a c# program to read two complex number and print the results of addition. 
*/

using System;

class Complex
{
    private int real;
    private int imaginary;

    public Complex(int real, int imaginary)
    {
        this.real = real;
        this.imaginary = imaginary;
    }

    public static Complex operator + (Complex c1, Complex c2)
    {
        return new Complex(c1.real + c2.real, c1.imaginary + c2.imaginary);
    }

    public void Display()
    {
        Console.WriteLine($"{real} + {imaginary}i");
    }
}

class Lab9
{
    static void Main()
    {
        Console.Write("Enter the real part of the first complex number: ");
        int real1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the imaginary part of the first complex number: ");
        int imaginary1 = Convert.ToInt32(Console.ReadLine());
        Complex c1 = new Complex(real1, imaginary1);

        Console.Write("Enter the real part of the second complex number: ");
        int real2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the imaginary part of the second complex number: ");
        int imaginary2 = Convert.ToInt32(Console.ReadLine());
        Complex c2 = new Complex(real2, imaginary2);

        Complex sum = c1 + c2;
        Console.Write("Sum of the complex numbers: ");
        sum.Display();
    }
}
