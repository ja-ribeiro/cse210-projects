using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");

        // Address + customer 1 (USA)
        Address address1 = new Address(
            "123 Main Street",
            "New York",
            "NY",
            "USA"
        );

        Customer customer1 = new Customer("Ethan Simon", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "P1001", 900, 1));
        order1.AddProduct(new Product("Mouse", "P1002", 25, 2));

        // Address + customer 2 (International)
        Address address2 = new Address(
            "Rua Cica, 450",
            "Rio de Janeiro",
            "RJ",
            "BRAZIL"
        );

        Customer customer2 = new Customer("Maria Oliveira", address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Phone", "P2001", 700, 1));
        order2.AddProduct(new Product("Headphones", "P2002", 80, 1));
        order2.AddProduct(new Product("Charger", "P2003", 30, 2));

        // Display Order 1
        Console.WriteLine("----------------------------------");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.CalculateTotalCost()}");

        // Display Order 2
        Console.WriteLine("----------------------------------");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.CalculateTotalCost()}");
    }
}