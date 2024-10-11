using System;

class Program
{
    static void Main(string[] args)
    {
        // Create Address and Customer
        Address address1 = new Address("123 Sesame St", "New York", "NY", "USA");
        Customer customer1 = new Customer("Naht El Moe", address1);

        // Create Products
        Product product1 = new Product("Laptop", "A123", 999.99m, 1);
        Product product2 = new Product("Mouse", "B456", 25.99m, 2);

        // Create an Order
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        // Display Information
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost():0.00}");
    }
}
