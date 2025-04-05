using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Customer customer1 = new Customer("Chadwick", "USA");
        Customer customer2 = new Customer("Brandon", "Canada");

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", 101, 1200, 1));
        order1.AddProduct(new Product("Mouse", 102, 25, 2));
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Phone", 201, 800, 1));
        order2.AddProduct(new Product("Charger", 202, 30, 1));
        
        order1.DisplayPackingLabel();
        order1.DisplayShippingLabel();
        Console.WriteLine("Total Cost: $" + order1.TotalCost());
        Console.WriteLine();
        order2.DisplayPackingLabel();
        order2.DisplayShippingLabel();
        Console.WriteLine("Total Cost: $" + order2.TotalCost());
    }
}