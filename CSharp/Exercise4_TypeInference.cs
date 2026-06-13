using System;

// Exercise 4: Write a C# program to Demonstrate Type Inference with var and new()
// Objective: Understand the use of type inference in C#.

class MyClass
{
    public int Id { get; set; }
    public string Name { get; set; }
}

class Exercise4_TypeInference
{
    static void Main()
    {
        // Using var with different types
        var intVar = 42;
        var stringVar = "Hello, World!";
        var doubleVar = 3.14;
        var boolVar = true;

        // Using new() with explicit type
        var myObject = new MyClass { Id = 1, Name = "Test" };

        // Display types and values
        Console.WriteLine("Type Inference with var:");
        Console.WriteLine($"intVar: Type = {intVar.GetType().Name}, Value = {intVar}");
        Console.WriteLine($"stringVar: Type = {stringVar.GetType().Name}, Value = {stringVar}");
        Console.WriteLine($"doubleVar: Type = {doubleVar.GetType().Name}, Value = {doubleVar}");
        Console.WriteLine($"boolVar: Type = {boolVar.GetType().Name}, Value = {boolVar}");

        Console.WriteLine($"\nObject created with new():");
        Console.WriteLine($"myObject: Type = {myObject.GetType().Name}");
        Console.WriteLine($"  Id = {myObject.Id}, Name = {myObject.Name}");

        Console.WriteLine("\nBenefits of type inference:");
        Console.WriteLine("- Cleaner code when type is obvious from context");
        Console.WriteLine("- Beneficial for long generic type names");
        Console.WriteLine("- May reduce readability in complex scenarios");
    }
}
