using System;

// Exercise 16: Write a C# program to Handle Null References Safely
// Objective: Safely handle nullable references in C#.

class Person
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public Address? Address { get; set; }
}

class Address
{
    public string? City { get; set; }
    public string? Country { get; set; }
}

class Exercise16_HandleNullReferences
{
    static void Main()
    {
        Console.WriteLine("Handling Null References Safely\n");

        // Using null-conditional operator (?.)
        Person person1 = new Person
        {
            FirstName = "John",
            LastName = "Doe",
            Address = new Address { City = "New York", Country = "USA" }
        };

        Console.WriteLine("Person 1 (all properties set):");
        Console.WriteLine($"  Name: {person1.FirstName} {person1.LastName}");
        Console.WriteLine($"  City: {person1.Address?.City}");
        Console.WriteLine($"  Country: {person1.Address?.Country}\n");

        // Person with null address
        Person person2 = new Person
        {
            FirstName = "Jane",
            LastName = "Smith",
            Address = null
        };

        Console.WriteLine("Person 2 (address is null):");
        Console.WriteLine($"  Name: {person2.FirstName} {person2.LastName}");
        Console.WriteLine($"  City: {person2.Address?.City ?? "N/A"}");
        Console.WriteLine($"  Country: {person2.Address?.Country ?? "Unknown"}\n");

        // Person with null properties
        Person person3 = null;
        Console.WriteLine("Person 3 (person is null):");
        Console.WriteLine($"  Name: {person3?.FirstName ?? "Unknown"} {person3?.LastName ?? "Unknown"}");
        Console.WriteLine($"  City: {person3?.Address?.City ?? "N/A"}\n");

        Console.WriteLine("Null handling operators:");
        Console.WriteLine("  ?. (null-conditional): Safely access properties");
        Console.WriteLine("  ?? (null-coalescing): Provide default value");
        Console.WriteLine("  ??= (null-coalescing assignment): Assign if null");
    }
}
