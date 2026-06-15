using System;

// Exercise 18: Write a C# program to Use the required Modifier in C# 12
// Objective: Use the required modifier to enforce required properties in a class.

class Student
{
    public required string StudentId { get; set; }
    public required string Name { get; set; }
    public required string Major { get; set; }
    public int GPA { get; set; } // Not required
}

class Exercise18_RequiredModifier
{
    static void Main()
    {
        Console.WriteLine("Required Modifier in C# 12\n");

        // This will compile and run fine - all required properties are set
        var student1 = new Student
        {
            StudentId = "S001",
            Name = "Alice",
            Major = "Computer Science",
            GPA = 35
        };

        Console.WriteLine("Student 1 (all required properties set):");
        Console.WriteLine($"  ID: {student1.StudentId}");
        Console.WriteLine($"  Name: {student1.Name}");
        Console.WriteLine($"  Major: {student1.Major}");
        Console.WriteLine($"  GPA: {student1.GPA}\n");

        // Attempting to create student without required property
        // This would cause a compiler error:
        // var student2 = new Student
        // {
        //     StudentId = "S002",
        //     Name = "Bob"
        //     // Major is required but not provided - COMPILER ERROR
        // };

        var student2 = new Student
        {
            StudentId = "S002",
            Name = "Bob",
            Major = "Engineering"
            // GPA is optional, so it defaults to 0
        };

        Console.WriteLine("Student 2 (without optional GPA):");
        Console.WriteLine($"  ID: {student2.StudentId}");
        Console.WriteLine($"  Name: {student2.Name}");
        Console.WriteLine($"  Major: {student2.Major}");
        Console.WriteLine($"  GPA: {student2.GPA}\n");

        Console.WriteLine("The 'required' modifier:");
        Console.WriteLine("  - Enforces properties must be set during initialization");
        Console.WriteLine("  - Compiler error if required properties are missing");
        Console.WriteLine("  - Improves data integrity and reduces bugs");
    }
}
