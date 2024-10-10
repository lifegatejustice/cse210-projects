using System;

class Program
{
    static void Main(string[] args)
    {
        // Create two addresses
        Address address1 = new Address("123 Awolowo Road", "Lagos", "Lagos State", "Nigeria");
        Address address2 = new Address("456 Piccadilly Avenue", "London", "England", "United Kingdom");

        // Create two customers
        Customer customer1 = new Customer("Chinaza Okafor", address1);
        Customer customer2 = new Customer("Emma Thompson", address2);

        // Create products for order 1
        Product product1 = new Product("Laptop", "P001", 1200.00, 1);
        Product product2 = new Product("Mouse", "P002", 25.50, 2);

        // Create products for order 2
        Product product3 = new Product("Desk Chair", "P003", 150.00, 1);
        Product product4 = new Product("Monitor", "P004", 300.00, 1);

        // Create two orders
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);

        // Display order 1 details
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalPrice()}\n");

        // Display order 2 details
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalPrice()}");
    }
}
