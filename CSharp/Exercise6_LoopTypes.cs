using System;

// Exercise 6: Write a C# program to Loop Through an Array with Different Loop Types
// Objective: Practice iterating over arrays using various loops.

class Exercise6_LoopTypes
{
    static void Main()
    {
        int[] numbers = { 10, 20, 30, 40, 50 };

        Console.WriteLine("Original Array: " + string.Join(", ", numbers));

        // Using for loop
        Console.WriteLine("\nUsing for loop:");
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] == 30)
            {
                Console.WriteLine($"  Index {i}: {numbers[i]} (skipped - value is 30)");
                continue;
            }
            Console.WriteLine($"  Index {i}: {numbers[i]}");
        }

        // Using foreach loop
        Console.WriteLine("\nUsing foreach loop:");
        foreach (int num in numbers)
        {
            Console.WriteLine($"  Value: {num}");
        }

        // Using while loop
        Console.WriteLine("\nUsing while loop:");
        int index = 0;
        while (index < numbers.Length)
        {
            if (numbers[index] > 35)
            {
                Console.WriteLine($"  Index {index}: {numbers[index]} (stopped - value > 35)");
                break;
            }
            Console.WriteLine($"  Index {index}: {numbers[index]}");
            index++;
        }

        // Using do-while loop
        Console.WriteLine("\nUsing do-while loop:");
        int idx = 0;
        do
        {
            Console.WriteLine($"  Index {idx}: {numbers[idx]}");
            idx++;
        } while (idx < numbers.Length && idx < 3);
    }
}
