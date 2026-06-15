using System;

// Exercise 15: Write a C# program to Differentiate Abstract Classes and Interfaces
// Objective: Understand the differences between abstract classes and interfaces.

abstract class Vehicle
{
    public string Make { get; set; }

    public abstract void Drive();

    public virtual void Honk()
    {
        Console.WriteLine("  Honk! Honk!");
    }
}

interface IDrivable
{
    void Start();
    void Stop();
}

interface IElectric
{
    void Charge();
}

class Car : Vehicle, IDrivable, IElectric
{
    public Car(string make)
    {
        Make = make;
    }

    public override void Drive()
    {
        Console.WriteLine($"  {Make} car is driving on the road");
    }

    public void Start()
    {
        Console.WriteLine($"  {Make} car engine started");
    }

    public void Stop()
    {
        Console.WriteLine($"  {Make} car engine stopped");
    }

    public void Charge()
    {
        Console.WriteLine($"  {Make} car is charging");
    }
}

class Exercise15_AbstractClassesAndInterfaces
{
    static void Main()
    {
        Console.WriteLine("Abstract Classes and Interfaces\n");

        Car myCar = new Car("Tesla");

        Console.WriteLine("Using abstract class method:");
        myCar.Drive();
        myCar.Honk();

        Console.WriteLine("\nUsing interface methods:");
        myCar.Start();
        myCar.Charge();
        myCar.Stop();

        Console.WriteLine("\nDifferences:");
        Console.WriteLine("  Abstract Classes:");
        Console.WriteLine("    - Can have state (fields)");
        Console.WriteLine("    - Can have implemented methods");
        Console.WriteLine("    - Single inheritance only");
        Console.WriteLine("\n  Interfaces:");
        Console.WriteLine("    - No state (no fields)");
        Console.WriteLine("    - All methods are abstract (unless default)");
        Console.WriteLine("    - Multiple implementation");
    }
}
