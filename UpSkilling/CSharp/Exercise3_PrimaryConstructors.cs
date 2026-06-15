using System;

// Exercise 3: Write a C# program to Use Primary Constructors in C# 12
// Objective: Explore the use of primary constructors in C# 12.

record Person(string FirstName, string LastName, int Age)
{
    public void DisplayInfo()
    {
        Console.WriteLine($"Full Name: {FirstName} {LastName}, Age: {Age}");
    }
}

class Exercise3_PrimaryConstructors
{
    static void Main()
    {
        Person person1 = new("John", "Doe", 30);
        Person person2 = new("Jane", "Smith", 28);

        Console.WriteLine("People created using primary constructor:");
        person1.DisplayInfo();
        person2.DisplayInfo();

        Console.WriteLine($"\nUsing auto-implemented properties:");
        Console.WriteLine($"Person 1: {person1.FirstName} {person1.LastName}, {person1.Age} years old");
        Console.WriteLine($"Person 2: {person2.FirstName} {person2.LastName}, {person2.Age} years old");
    }
}
