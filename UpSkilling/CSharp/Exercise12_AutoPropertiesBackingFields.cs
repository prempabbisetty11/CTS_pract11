using System;

// Exercise 12: Write a C# program to Use Auto-Properties and Backing Fields
// Objective: Understand the use of auto-properties and backing fields.

class Product
{
    private decimal _price;

    public string Name { get; set; }

    public decimal Price
    {
        get { return _price; }
        set
        {
            if (value < 0)
            {
                Console.WriteLine($"Error: Price cannot be negative. Setting to 0.");
                _price = 0;
            }
            else
            {
                _price = value;
            }
        }
    }

    public Product(string name, decimal price)
    {
        Name = name;
        Price = price;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"  Product: {Name}, Price: ${Price:F2}");
    }
}

class Exercise12_AutoPropertiesBackingFields
{
    static void Main()
    {
        Console.WriteLine("Auto-Properties and Backing Fields\n");

        // Valid product
        Product product1 = new Product("Laptop", 999.99m);
        product1.DisplayInfo();

        // Attempting to set negative price (validation in backing field)
        Console.WriteLine("\nAttempting to set negative price:");
        Product product2 = new Product("Phone", -500m);
        product2.DisplayInfo();

        // Updating price
        Console.WriteLine("\nUpdating product2 price:");
        product2.Price = 599.99m;
        product2.DisplayInfo();

        Console.WriteLine("\nBenefits of backing fields:");
        Console.WriteLine("  - Validation of property values");
        Console.WriteLine("  - Custom logic in getters/setters");
        Console.WriteLine("  - Auto-properties reduce boilerplate for simple properties");
    }
}
