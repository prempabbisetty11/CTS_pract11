using System;

// Exercise 21: Write a C# program to Use Pattern Matching with is and switch
// Objective: Explore the power of pattern matching with is and switch.

class Exercise21_PatternMatching
{
    static void AnalyzeObject(object obj)
    {
        Console.WriteLine($"Object type: {obj?.GetType().Name ?? "null"}\n");

        // Using pattern matching with is
        if (obj is string str)
        {
            Console.WriteLine($"  String value: {str} (length: {str.Length})");
        }
        else if (obj is int intValue && intValue > 0)
        {
            Console.WriteLine($"  Positive integer: {intValue}");
        }
        else if (obj is int intValue2)
        {
            Console.WriteLine($"  Integer: {intValue2}");
        }
        else if (obj is double dblValue)
        {
            Console.WriteLine($"  Double value: {dblValue:F2}");
        }
        else if (obj is null)
        {
            Console.WriteLine("  Object is null");
        }
        else
        {
            Console.WriteLine($"  Unknown type: {obj.GetType().Name}");
        }
    }

    static string DescribeValue(object value)
    {
        // Using switch expression with pattern matching
        return value switch
        {
            null => "Value is null",
            string s when s.Length == 0 => "Empty string",
            string s => $"String with {s.Length} characters",
            int i when i < 0 => "Negative integer",
            int i when i == 0 => "Zero",
            int i => $"Positive integer: {i}",
            double d => $"Double: {d:F2}",
            bool b => $"Boolean: {b}",
            _ => "Unknown type"
        };
    }

    static void Main()
    {
        Console.WriteLine("Pattern Matching with is and switch\n");

        object[] testObjects = { "Hello", 42, -15, 3.14, true, "", null };

        Console.WriteLine("=== Using is Pattern Matching ===\n");
        foreach (object obj in testObjects)
        {
            AnalyzeObject(obj);
            Console.WriteLine();
        }

        Console.WriteLine("=== Using switch Expression Pattern Matching ===\n");
        foreach (object obj in testObjects)
        {
            string description = DescribeValue(obj);
            Console.WriteLine($"  {description}");
        }

        Console.WriteLine("\nPattern Matching Benefits:");
        Console.WriteLine("  - Type-safe checking with is");
        Console.WriteLine("  - Concise switch expressions");
        Console.WriteLine("  - Guards (when clauses) for additional conditions");
        Console.WriteLine("  - Reduces boilerplate code");
    }
}
