using System;

// Exercise 17: Write a C# program to Use Null-Conditional Chaining in a Contact App
// Objective: Implement null-conditional chaining to avoid null reference exceptions.

class Contact
{
    public string? Name { get; set; }
    public string? PhoneNumber { get; set; }
    public Address? Address { get; set; }
}

class Address
{
    public string? Street { get; set; }
    public string? City { get; set; }
    public string? Country { get; set; }
}

class Exercise17_NullConditionalChainingContactApp
{
    static void DisplayContact(Contact contact)
    {
        if (contact == null)
        {
            Console.WriteLine("  Contact is null");
            return;
        }

        string name = contact.Name ?? "Unknown";
        string phone = contact.PhoneNumber ?? "N/A";
        string city = contact.Address?.City ?? "N/A";
        string country = contact.Address?.Country ?? "Unknown";

        Console.WriteLine($"  Name: {name}");
        Console.WriteLine($"  Phone: {phone}");
        Console.WriteLine($"  City: {city}");
        Console.WriteLine($"  Country: {country}");
    }

    static void Main()
    {
        Console.WriteLine("Contact App with Null-Conditional Chaining\n");

        // Contact 1: Complete information
        Contact contact1 = new Contact
        {
            Name = "Alice Johnson",
            PhoneNumber = "555-1234",
            Address = new Address
            {
                City = "New York",
                Country = "USA"
            }
        };

        Console.WriteLine("Contact 1 (complete):");
        DisplayContact(contact1);

        // Contact 2: Partial information (no address)
        Contact contact2 = new Contact
        {
            Name = "Bob Smith",
            PhoneNumber = "555-5678",
            Address = null
        };

        Console.WriteLine("\nContact 2 (no address):");
        DisplayContact(contact2);

        // Contact 3: Minimal information
        Contact contact3 = new Contact
        {
            Name = "Charlie Brown"
        };

        Console.WriteLine("\nContact 3 (minimal info):");
        DisplayContact(contact3);

        // Contact 4: Null contact
        Contact contact4 = null;
        Console.WriteLine("\nContact 4 (null):");
        DisplayContact(contact4);

        Console.WriteLine("\nNull-Conditional Chaining Benefits:");
        Console.WriteLine("  - Prevents NullReferenceException");
        Console.WriteLine("  - Cleaner, more readable code");
        Console.WriteLine("  - Safely navigates nested objects");
    }
}
