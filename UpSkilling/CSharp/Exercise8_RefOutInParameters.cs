using System;

// Exercise 8: Write a C# program to Use ref, out, and in Parameters
// Objective: Understand and demonstrate ref, out, and in parameters.

class Exercise8_RefOutInParameters
{
    // Method using ref - can read and modify
    static void ModifyWithRef(ref int value)
    {
        Console.WriteLine($"  Inside ModifyWithRef (before): {value}");
        value = 100;
        Console.WriteLine($"  Inside ModifyWithRef (after): {value}");
    }

    // Method using out - must set value before returning
    static void GetValues(out int x, out string message)
    {
        x = 42;
        message = "Value set via out parameter";
    }

    // Method using in - read-only, cannot modify
    static void DisplayWithIn(in int value)
    {
        Console.WriteLine($"  In parameter value: {value}");
        // value = 50;  // Compiler error - cannot modify in parameter
    }

    static void Main()
    {
        Console.WriteLine("ref, out, and in Parameter Demonstration\n");

        // Using ref parameter
        Console.WriteLine("Using ref parameter:");
        int refValue = 10;
        Console.WriteLine($"Before ModifyWithRef: {refValue}");
        ModifyWithRef(ref refValue);
        Console.WriteLine($"After ModifyWithRef: {refValue}\n");

        // Using out parameter
        Console.WriteLine("Using out parameter:");
        int outValue;
        string outMessage;
        GetValues(out outValue, out outMessage);
        Console.WriteLine($"out value: {outValue}");
        Console.WriteLine($"out message: {outMessage}\n");

        // Using in parameter
        Console.WriteLine("Using in parameter:");
        int inValue = 25;
        Console.WriteLine($"Before DisplayWithIn: {inValue}");
        DisplayWithIn(in inValue);
        Console.WriteLine($"After DisplayWithIn: {inValue} (unchanged)\n");

        Console.WriteLine("Summary:");
        Console.WriteLine("  ref: Pass by reference, can read and modify");
        Console.WriteLine("  out: Pass by reference, must be set before returning");
        Console.WriteLine("  in: Pass by reference, read-only (optimization)");
    }
}
