using System;

// Exercise 10: Write a C# program to Demonstrate OOP Basics with Constructors
// Objective: Implement object-oriented concepts using constructors.

class Car
{
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }

    // Default constructor
    public Car()
    {
        Make = "Unknown";
        Model = "Unknown";
        Year = 0;
    }

    // Parameterized constructor
    public Car(string make, string model, int year)
    {
        Make = make;
        Model = model;
        Year = year;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"  Make: {Make}, Model: {Model}, Year: {Year}");
    }
}

class Exercise10_OOPBasics
{
    static void Main()
    {
        Console.WriteLine("OOP Basics - Constructors Demonstration\n");

        // Using default constructor
        Console.WriteLine("Using default constructor:");
        Car car1 = new Car();
        car1.DisplayInfo();

        // Using parameterized constructor
        Console.WriteLine("\nUsing parameterized constructor:");
        Car car2 = new Car("Toyota", "Corolla", 2023);
        car2.DisplayInfo();

        Car car3 = new Car("Honda", "Civic", 2022);
        car3.DisplayInfo();

        Console.WriteLine("\nConstructors allow:");
        Console.WriteLine("  - Initialization of object properties");
        Console.WriteLine("  - Default and parameterized versions");
        Console.WriteLine("  - Proper object setup before use");
    }
}
