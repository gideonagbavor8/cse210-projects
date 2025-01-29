// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Hello World! This is the OnlineOrdering Project.");
//     }
// }

using System;
using System.Collections.Generic;
// using System.IO;



class Program
{
    static void Main()
    {
        // Creating addresses
        Address address1 = new Address("123 Main St", "Los Angeles", "CA", "USA");
        Address address2 = new Address("456 Maple Ave", "Toronto", "ON", "Canada");
        Address address3 = new Address("789 Elm St", "Accra", "Greater Accra", "Ghana");
        Address address4 = new Address("101 Pine St", "Nairobi", "Nairobi County", "Kenya");

        // Creating customers
        Customer customer1 = new Customer("John Doe", address1);
        Customer customer2 = new Customer("Jane Smith", address2);
        Customer customer3 = new Customer("Gideon Agbavor", address3);
        Customer customer4 = new Customer("Wangari Maathai", address4);

        // Creating orders
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "P001", 999.99m, 1));
        order1.AddProduct(new Product("Mouse", "P002", 25.50m, 2));

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Smartphone", "P003", 499.99m, 1));
        order2.AddProduct(new Product("Charger", "P004", 19.99m, 3));

        Order order3 = new Order(customer3);
        order3.AddProduct(new Product("Ipad", "P005", 299.99m, 1));
        order3.AddProduct(new Product("Hp Laptop", "P006", 49.99m, 2));

        Order order4 = new Order(customer4);
        order4.AddProduct(new Product("Camera", "P007", 599.99m, 1));
        order4.AddProduct(new Product("Tripod", "P008", 39.99m, 1));

        // Displaying order details
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost():F2}\n");

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost():F2}");

        Console.WriteLine(order3.GetPackingLabel());
        Console.WriteLine(order3.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order3.GetTotalCost():F2}\n");

        Console.WriteLine(order4.GetPackingLabel());
        Console.WriteLine(order4.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order4.GetTotalCost():F2}");
    }
}

