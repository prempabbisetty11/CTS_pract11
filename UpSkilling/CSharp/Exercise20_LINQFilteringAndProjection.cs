using System;
using System.Collections.Generic;
using System.Linq;

// Exercise 20: Write a C# program to Use LINQ for Filtering and Projection
// Objective: Learn how to use LINQ for querying collections.

class Order
{
    public int OrderId { get; set; }
    public string CustomerName { get; set; }
    public decimal TotalAmount { get; set; }
}

class Exercise20_LINQFilteringAndProjection
{
    static void Main()
    {
        Console.WriteLine("LINQ for Filtering and Projection\n");

        // Create sample orders
        List<Order> orders = new List<Order>
        {
            new Order { OrderId = 1, CustomerName = "Alice", TotalAmount = 150.50m },
            new Order { OrderId = 2, CustomerName = "Bob", TotalAmount = 75.25m },
            new Order { OrderId = 3, CustomerName = "Charlie", TotalAmount = 250.00m },
            new Order { OrderId = 4, CustomerName = "Diana", TotalAmount = 120.75m },
            new Order { OrderId = 5, CustomerName = "Eve", TotalAmount = 300.00m }
        };

        Console.WriteLine("=== All Orders ===");
        foreach (var order in orders)
        {
            Console.WriteLine($"  Order {order.OrderId}: {order.CustomerName} - ${order.TotalAmount:F2}");
        }

        // LINQ: Filter orders with amount > 150
        Console.WriteLine("\n=== Orders with TotalAmount > $150 ===");
        var highValueOrders = orders.Where(o => o.TotalAmount > 150).ToList();
        foreach (var order in highValueOrders)
        {
            Console.WriteLine($"  Order {order.OrderId}: {order.CustomerName} - ${order.TotalAmount:F2}");
        }

        // LINQ: Projection to anonymous type
        Console.WriteLine("\n=== Customer Names and Amounts (Projected) ===");
        var projectedOrders = orders
            .Where(o => o.TotalAmount > 100)
            .Select(o => new { o.CustomerName, o.TotalAmount })
            .ToList();

        foreach (var order in projectedOrders)
        {
            Console.WriteLine($"  {order.CustomerName}: ${order.TotalAmount:F2}");
        }

        // LINQ: Filtering and sorting
        Console.WriteLine("\n=== Orders Sorted by Amount (Descending) ===");
        var sortedOrders = orders
            .Where(o => o.TotalAmount > 100)
            .OrderByDescending(o => o.TotalAmount)
            .ToList();

        foreach (var order in sortedOrders)
        {
            Console.WriteLine($"  {order.CustomerName}: ${order.TotalAmount:F2}");
        }

        // LINQ: Aggregation
        Console.WriteLine("\n=== LINQ Aggregation ===");
        decimal totalSales = orders.Sum(o => o.TotalAmount);
        decimal averageOrder = orders.Average(o => o.TotalAmount);
        decimal maxOrder = orders.Max(o => o.TotalAmount);

        Console.WriteLine($"  Total Sales: ${totalSales:F2}");
        Console.WriteLine($"  Average Order: ${averageOrder:F2}");
        Console.WriteLine($"  Highest Order: ${maxOrder:F2}");

        Console.WriteLine("\nLINQ Benefits:");
        Console.WriteLine("  - Declarative query syntax");
        Console.WriteLine("  - Type-safe filtering and projection");
        Console.WriteLine("  - Chainable operations (fluent API)");
        Console.WriteLine("  - Works with any IEnumerable<T> collection");
    }
}
