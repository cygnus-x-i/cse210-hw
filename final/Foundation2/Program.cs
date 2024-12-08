class Program
{
    static void Main(string[] args)
    {
        // Create Addresses
        Address address1 = new Address("123 Main St", "Springfield", "IL", "USA");
        Address address2 = new Address("456 Elm St", "Toronto", "ON", "Canada");

        // Create Customers
        Customer customer1 = new Customer("John Doe", address1);
        Customer customer2 = new Customer("Jane Smith", address2);

        // Create Orders
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Widget", "W123", 3.50m, 4));
        order1.AddProduct(new Product("Gadget", "G456", 15.99m, 2));

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Thingamajig", "T789", 9.99m, 3));
        order2.AddProduct(new Product("Doodad", "D101", 7.50m, 5));

        // Display Order 1 Info
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.CalculateTotalCost():F2}\n");

        // Display Order 2 Info
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.CalculateTotalCost():F2}\n");
    }
}