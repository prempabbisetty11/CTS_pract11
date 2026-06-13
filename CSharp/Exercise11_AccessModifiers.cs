using System;

// Exercise 11: Write a C# program to Demonstrate Access Modifiers
// Objective: Understand access modifiers and their visibility.

class BaseClass
{
    public int PublicField = 10;
    private int PrivateField = 20;
    protected int ProtectedField = 30;
    internal int InternalField = 40;

    public void DisplayAll()
    {
        Console.WriteLine($"  Public: {PublicField}");
        Console.WriteLine($"  Private: {PrivateField}");
        Console.WriteLine($"  Protected: {ProtectedField}");
        Console.WriteLine($"  Internal: {InternalField}");
    }

    protected void ProtectedMethod()
    {
        Console.WriteLine("  This is a protected method");
    }
}

class DerivedClass : BaseClass
{
    public void AccessProtected()
    {
        Console.WriteLine($"Accessing from derived class:");
        Console.WriteLine($"  Public: {PublicField}");
        Console.WriteLine($"  Protected: {ProtectedField}");
        ProtectedMethod();
        // Console.WriteLine(PrivateField);  // Error: inaccessible
    }
}

class Exercise11_AccessModifiers
{
    static void Main()
    {
        Console.WriteLine("Access Modifiers Demonstration\n");

        BaseClass baseObj = new BaseClass();
        Console.WriteLine("Accessing from non-derived class:");
        baseObj.DisplayAll();

        Console.WriteLine("\nAccessing derived class protected members:");
        DerivedClass derivedObj = new DerivedClass();
        derivedObj.AccessProtected();

        Console.WriteLine("\nAccess Modifier Summary:");
        Console.WriteLine("  public: Accessible everywhere");
        Console.WriteLine("  private: Accessible only within the same class");
        Console.WriteLine("  protected: Accessible within the class and derived classes");
        Console.WriteLine("  internal: Accessible within the same assembly");
    }
}
