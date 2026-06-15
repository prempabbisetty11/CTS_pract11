using System;

// Exercise 14: Write a C# program to Demonstrate Inheritance and Method Overriding
// Objective: Learn inheritance and method overriding.

abstract class Shape
{
    public virtual void Draw()
    {
        Console.WriteLine("  Drawing a shape");
    }

    public abstract double GetArea();
}

class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override void Draw()
    {
        Console.WriteLine($"  Drawing a circle with radius {Radius}");
    }

    public override double GetArea()
    {
        return Math.PI * Radius * Radius;
    }
}

class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public override void Draw()
    {
        Console.WriteLine($"  Drawing a rectangle {Width} x {Height}");
    }

    public override double GetArea()
    {
        return Width * Height;
    }
}

class Exercise14_InheritanceAndOverriding
{
    static void Main()
    {
        Console.WriteLine("Inheritance and Method Overriding\n");

        Shape circle = new Circle(5);
        Shape rectangle = new Rectangle(4, 6);

        Console.WriteLine("Circle:");
        circle.Draw();
        Console.WriteLine($"  Area: {circle.GetArea():F2}\n");

        Console.WriteLine("Rectangle:");
        rectangle.Draw();
        Console.WriteLine($"  Area: {rectangle.GetArea():F2}\n");

        Console.WriteLine("Inheritance benefits:");
        Console.WriteLine("  - Code reuse through inheritance");
        Console.WriteLine("  - Polymorphism via method overriding");
        Console.WriteLine("  - Abstract classes for enforcing contracts");
    }
}
