using System;

// Exercise 22: Write a C# program to Create and Deconstruct Tuples
// Objective: Learn how to use tuples for returning multiple values.

class Exercise22_Tuples
{
    // Method returning a tuple with int and string
    static (int Id, string Name) GetUserInfo()
    {
        return (123, "John Doe");
    }

    // Method returning tuple with multiple values
    static (int Sum, int Product, double Average) CalculateValues(int a, int b)
    {
        return (a + b, a * b, (a + b) / 2.0);
    }

    // Method with named tuple elements
    static (string FirstName, string LastName, int Age) GetPersonInfo()
    {
        return ("Alice", "Johnson", 28);
    }

    static void Main()
    {
        Console.WriteLine("Tuples and Deconstruction\n");

        // Deconstructing simple tuple
        Console.WriteLine("=== Simple Tuple Deconstruction ===");
        (int id, string name) = GetUserInfo();
        Console.WriteLine($"  User ID: {id}");
        Console.WriteLine($"  User Name: {name}");

        // Deconstructing tuple with multiple values
        Console.WriteLine("\n=== Multiple Values Tuple ===");
        (int sum, int product, double avg) = CalculateValues(10, 5);
        Console.WriteLine($"  Sum: {sum}");
        Console.WriteLine($"  Product: {product}");
        Console.WriteLine($"  Average: {avg:F2}");

        // Deconstructing named tuple
        Console.WriteLine("\n=== Named Tuple Deconstruction ===");
        (string firstName, string lastName, int age) = GetPersonInfo();
        Console.WriteLine($"  Name: {firstName} {lastName}");
        Console.WriteLine($"  Age: {age}");

        // Using discard (_) to ignore some values
        Console.WriteLine("\n=== Using Discard (_) ===");
        (int id2, _) = GetUserInfo();
        Console.WriteLine($"  Only captured ID: {id2}");

        // Accessing tuple elements without deconstruction
        Console.WriteLine("\n=== Accessing Without Deconstruction ===");
        var userInfo = GetUserInfo();
        Console.WriteLine($"  ID: {userInfo.Id}");
        Console.WriteLine($"  Name: {userInfo.Name}");

        Console.WriteLine("\nTuple Benefits:");
        Console.WriteLine("  - Return multiple values without creating a class");
        Console.WriteLine("  - Lightweight and easy to use");
        Console.WriteLine("  - Named elements improve readability");
        Console.WriteLine("  - Deconstruction simplifies code");
    }
}
