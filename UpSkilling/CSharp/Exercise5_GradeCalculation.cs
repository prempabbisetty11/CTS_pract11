using System;

// Exercise 5: Write a C# program to Perform Conditional Logic for Grade Calculation
// Objective: Use conditional statements to calculate and display grades using pattern matching.

class Exercise5_GradeCalculation
{
    static string CalculateGrade(int score)
    {
        // Using pattern matching in switch expression
        return score switch
        {
            >= 90 => "A",
            >= 80 => "B",
            >= 70 => "C",
            >= 60 => "D",
            _ => "F"
        };
    }

    static string GetGradeDescription(int score)
    {
        // Traditional if-else-if
        if (score >= 90)
        {
            return "Excellent";
        }
        else if (score >= 80)
        {
            return "Good";
        }
        else if (score >= 70)
        {
            return "Satisfactory";
        }
        else if (score >= 60)
        {
            return "Passing";
        }
        else
        {
            return "Failing";
        }
    }

    static void Main()
    {
        Console.WriteLine("Grade Calculation System\n");

        int[] scores = { 95, 87, 75, 68, 55 };

        foreach (int score in scores)
        {
            string grade = CalculateGrade(score);
            string description = GetGradeDescription(score);
            Console.WriteLine($"Score: {score} -> Grade: {grade} ({description})");
        }

        Console.WriteLine("\nUsing switch with pattern matching:");
        Console.WriteLine("Scores >= 90: A, >= 80: B, >= 70: C, >= 60: D, < 60: F");
    }
}
