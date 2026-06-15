using System;

// Exercise 9: Write a C# program to Use Local Functions
// Objective: Learn how to define and use local functions.

class Exercise9_LocalFunctions
{
    static long CalculateFactorial(int n)
    {
        // Local function for factorial calculation
        long LocalFactorial(int num)
        {
            if (num <= 1)
                return 1;
            return num * LocalFactorial(num - 1);
        }

        // Validate input using local function
        bool IsValidInput(int input)
        {
            return input >= 0 && input <= 20;
        }

        if (!IsValidInput(n))
        {
            Console.WriteLine($"Invalid input: {n}. Please enter a number between 0 and 20.");
            return -1;
        }

        return LocalFactorial(n);
    }

    static void Main()
    {
        Console.WriteLine("Local Functions - Factorial Calculator\n");

        int[] numbers = { 0, 5, 10, 15, 21 };

        foreach (int num in numbers)
        {
            long result = CalculateFactorial(num);
            if (result != -1)
            {
                Console.WriteLine($"Factorial of {num} = {result}");
            }
        }

        Console.WriteLine("\nLocal functions are helpful for:");
        Console.WriteLine("  - Encapsulating helper logic within a method");
        Console.WriteLine("  - Recursive calculations");
        Console.WriteLine("  - Improving code readability and organization");
    }
}
