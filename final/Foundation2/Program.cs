using System;

class Program
{
    static void Main(string[] args)
    {
        // Create addresses
        Address address1 = new Address("123 Maple Street", "Springfield", "IL", "USA");
        Address address2 = new Address("456 Elm Street", "Toronto", "ON", "Canada");

        // Create customers
        Customer customer1 = new Customer("Joseph Joestar", address1);
        Customer customer2 = new Customer("Jolyne Kujo", address2);

        // Create products
        Product product1 = new Product("Widget", "A123", 10.0, 2);
        Product product2 = new Product("Gadget", "B456", 15.0, 3);
        Product product3 = new Product("Doodad", "C789", 7.5, 5);

        // Create orders
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product2);
        order2.AddProduct(product3);

        // Display order details
        Console.WriteLine("Order 1 Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("\nOrder 1 Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("\nOrder 1 Total Cost:");
        Console.WriteLine(order1.GetTotalCost());

        Console.WriteLine("\nOrder 2 Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("\nOrder 2 Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("\nOrder 2 Total Cost:");
        Console.WriteLine(order2.GetTotalCost());
    }
}