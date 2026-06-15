using System;

// Exercise 7: Write a C# program to Implement Method Overloading
// Objective: Demonstrate method overloading with different parameter types and counts.

class Exercise7_MethodOverloading
{
    // Overload 1: Two integers
    static int CalculateTotal(int a, int b)
    {
        return a + b;
    }

    // Overload 2: Three doubles
    static double CalculateTotal(double a, double b, double c)
    {
        return a + b + c;
    }

    // Overload 3: Two doubles
    static double CalculateTotal(double a, double b)
    {
        return a + b;
    }

    // Overload 4: Array of integers
    static int CalculateTotal(int[] numbers)
    {
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }
        return sum;
    }

    // Overload 5: String and integer (concatenation)
    static string CalculateTotal(string label, int value)
    {
        return $"{label}: {value}";
    }

    static void Main()
    {
        Console.WriteLine("Method Overloading Examples:\n");

        // Calling different overloads
        Console.WriteLine($"CalculateTotal(5, 10) = {CalculateTotal(5, 10)}");
        Console.WriteLine($"CalculateTotal(2.5, 3.5, 1.5) = {CalculateTotal(2.5, 3.5, 1.5)}");
        Console.WriteLine($"CalculateTotal(4.2, 5.8) = {CalculateTotal(4.2, 5.8)}");

        int[] numbers = { 10, 20, 30, 40 };
        Console.WriteLine($"CalculateTotal(new int[]{{10, 20, 30, 40}}) = {CalculateTotal(numbers)}");

        Console.WriteLine($"CalculateTotal(\"Total\", 100) = {CalculateTotal("Total", 100)}");

        Console.WriteLine("\nMethod overloading allows the same method name with different signatures.");
    }
}
