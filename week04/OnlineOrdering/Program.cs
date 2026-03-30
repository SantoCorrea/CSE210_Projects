using System;

class Program
{
    static void Main(string[] args)
    {
        // Order 1 - US customer
        Address address1 = new Address("123 Main St", "Springfield", "IL", "USA");
        Customer customer1 = new Customer("John Smith", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "P001", 899.99m, 1));
        order1.AddProduct(new Product("Mouse", "P002", 49.99m, 2));
        order1.AddProduct(new Product("Keyboard", "P003", 79.99m, 1));

        // Order 2 - international customer
        Address address2 = new Address("45 Flower Street", "Sao Paulo", "SP", "Brazil");
        Customer customer2 = new Customer("Maria Silva", address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Monitor", "P004", 1299.99m, 1));
        order2.AddProduct(new Product("Webcam", "P005", 199.99m, 1));

        Console.WriteLine("========== ORDER 1 ==========");
        Console.WriteLine("\n--- Packing Label ---");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("--- Shipping Label ---");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"\nTotal: ${order1.GetTotalCost():F2}");

        Console.WriteLine("\n========== ORDER 2 ==========");
        Console.WriteLine("\n--- Packing Label ---");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("--- Shipping Label ---");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"\nTotal: ${order2.GetTotalCost():F2}");
    }
}