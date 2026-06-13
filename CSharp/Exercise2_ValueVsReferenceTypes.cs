using System;

// Exercise 2: Write a C# program to Explore Value vs Reference Types
// Objective: Understand the differences between value types and reference types.

class Exercise2_ValueVsReferenceTypes
{
    // Value type example
    struct Point
    {
        public int X;
        public int Y;
    }

    // Reference type example
    class Person
    {
        public string Name;
        public int Age;
    }

    static void ModifyValueType(Point p)
    {
        p.X = 100;
        p.Y = 200;
    }

    static void ModifyReferenceType(Person person)
    {
        person.Name = "Modified";
        person.Age = 50;
    }

    static void Main()
    {
        // Value Type (struct)
        Point point = new Point { X = 10, Y = 20 };
        Console.WriteLine($"Before ModifyValueType: X={point.X}, Y={point.Y}");
        ModifyValueType(point);
        Console.WriteLine($"After ModifyValueType: X={point.X}, Y={point.Y}");
        Console.WriteLine("Value types pass by value - changes don't affect original.\n");

        // Reference Type (class)
        Person person = new Person { Name = "John", Age = 30 };
        Console.WriteLine($"Before ModifyReferenceType: Name={person.Name}, Age={person.Age}");
        ModifyReferenceType(person);
        Console.WriteLine($"After ModifyReferenceType: Name={person.Name}, Age={person.Age}");
        Console.WriteLine("Reference types pass by reference - changes affect the original.");
    }
}
