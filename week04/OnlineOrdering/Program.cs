using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("19 Dominic", "Chicago", "illnios", "US");
        
        Customer customer1 = new Customer("John Doe", address1);

        Product product1 = new Product("Laptop", "LAP001", 900.0, 1);
        Product product2 = new Product("Phone", "MOB001", 1200.0, 2);
        Product product3 = new Product("TV", "TV001", 1900.0, 1);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        Console.WriteLine("Order 1");
        Console.WriteLine("Packing Label:\n" + order1.PackingLabel());
        Console.WriteLine("Shipping Label:\n" + order1.ShippingLabel());
        Console.WriteLine("Total Price : $" + order1.TotalCost());

        //Non USA
        Address address2 = new Address("19 Grimes", "Chersire", "Manchester", "UK");
        
        Customer customer2 = new Customer("Ben Jack", address2);

        Product product4 = new Product("Laptop", "LAP001", 900.0, 1);
        Product product5 = new Product("Phone", "MOB001", 1200.0, 2);
        Product product6 = new Product("TV", "TV001", 1900.0, 1);

        Order order2 = new Order(customer2);
        order2.AddProduct(product4);
        order2.AddProduct(product5);
        order2.AddProduct(product6);

        Console.WriteLine("Order 2");
        Console.WriteLine("Packing Label:\n" + order2.PackingLabel());
        Console.WriteLine("Shipping Label:\n" + order2.ShippingLabel());
        Console.WriteLine("Total Price : $" + order2.TotalCost());

    }
}