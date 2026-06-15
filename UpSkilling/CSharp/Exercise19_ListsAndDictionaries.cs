using System;
using System.Collections.Generic;

// Exercise 19: Write a C# program to Work with Lists and Dictionaries
// Objective: Understand how to work with List<T> and Dictionary<K, V> collections.

class Exercise19_ListsAndDictionaries
{
    static void Main()
    {
        Console.WriteLine("Lists and Dictionaries\n");

        // Working with List<string>
        Console.WriteLine("=== List<string> Example ===");
        List<string> fruits = new List<string> { "Apple", "Banana", "Orange", "Mango" };

        Console.WriteLine("Initial list:");
        foreach (string fruit in fruits)
        {
            Console.WriteLine($"  - {fruit}");
        }

        Console.WriteLine("\nAdding 'Grape':");
        fruits.Add("Grape");
        Console.WriteLine($"  List now has {fruits.Count} items");

        Console.WriteLine("\nRemoving 'Banana':");
        fruits.Remove("Banana");
        foreach (string fruit in fruits)
        {
            Console.WriteLine($"  - {fruit}");
        }

        // Working with Dictionary<int, string>
        Console.WriteLine("\n=== Dictionary<int, string> Example ===");
        Dictionary<int, string> capitals = new Dictionary<int, string>
        {
            { 1, "USA - Washington DC" },
            { 2, "UK - London" },
            { 3, "France - Paris" },
            { 4, "Japan - Tokyo" }
        };

        Console.WriteLine("Initial dictionary:");
        foreach (var entry in capitals)
        {
            Console.WriteLine($"  Key {entry.Key}: {entry.Value}");
        }

        Console.WriteLine("\nAdding new entry:");
        capitals[5] = "India - New Delhi";
        Console.WriteLine($"  Dictionary now has {capitals.Count} entries");

        Console.WriteLine("\nAccessing specific entry:");
        if (capitals.TryGetValue(2, out string value))
        {
            Console.WriteLine($"  Key 2: {value}");
        }

        Console.WriteLine("\nRemoving entry with key 3:");
        capitals.Remove(3);
        Console.WriteLine($"  Dictionary now has {capitals.Count} entries");

        Console.WriteLine("\nFinal dictionary:");
        foreach (var entry in capitals)
        {
            Console.WriteLine($"  Key {entry.Key}: {entry.Value}");
        }

        Console.WriteLine("\nList and Dictionary benefits:");
        Console.WriteLine("  - Flexible collection management");
        Console.WriteLine("  - Generic type safety with <T>");
        Console.WriteLine("  - Efficient add/remove/search operations");
    }
}
