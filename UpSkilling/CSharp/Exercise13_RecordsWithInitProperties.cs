using System;

// Exercise 13: Write a C# program to Create and Use Records with init Properties
// Objective: Explore the use of records and init properties in C# 9 and 12.

record Employee(string Name, string Department, decimal Salary)
{
    public void DisplayInfo()
    {
        Console.WriteLine($"  Name: {Name}, Department: {Department}, Salary: ${Salary:F2}");
    }
}

class Exercise13_RecordsWithInitProperties
{
    static void Main()
    {
        Console.WriteLine("Records with init Properties\n");

        // Creating employee records
        Employee employee1 = new("Alice Johnson", "Engineering", 95000);
        Console.WriteLine("Original record:");
        employee1.DisplayInfo();

        // Using with expression to create a modified copy
        Console.WriteLine("\nUsing 'with' expression to create a modified copy:");
        Employee employee2 = employee1 with { Salary = 105000 };
        employee2.DisplayInfo();

        // Verify original is unchanged
        Console.WriteLine("\nOriginal record after 'with' expression:");
        employee1.DisplayInfo();

        // Creating another modified copy with department change
        Employee employee3 = employee1 with { Department = "Management", Salary = 110000 };
        Console.WriteLine("\nAnother modified copy (department and salary changed):");
        employee3.DisplayInfo();

        Console.WriteLine("\nRecord benefits:");
        Console.WriteLine("  - Immutable by default");
        Console.WriteLine("  - 'with' expression for creating copies with changes");
        Console.WriteLine("  - Automatic equality comparison");
        Console.WriteLine("  - Cleaner syntax than classes for data containers");
    }
}
