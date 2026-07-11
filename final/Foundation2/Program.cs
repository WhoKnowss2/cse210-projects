using System;

class Program
{
    static void Main(string[] args)
    {
        // Order 1 - USA customer
        Address address1 = new Address(
            "123 Main Street",
            "Boise",
            "Idaho",
            "USA");

        Customer customer1 = new Customer(
            "Sarah Johnson",
            address1);

        Order order1 = new Order(customer1);

        Product product1 = new Product("Wireless Mouse", "WM101", 19.99, 2);
        Product product2 = new Product("Keyboard", "KB205", 35.50, 1);
        Product product3 = new Product("USB Cable", "UC115", 8.25, 3);
        Product product4 = new Product("Laptop Stand", "LS310", 29.99, 1);

        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);
        order1.AddProduct(product4);


        // Order 2 - Canada customer
        Address address2 = new Address(
            "45 King Street",
            "Toronto",
            "Ontario",
            "Canada");

        Customer customer2 = new Customer(
            "Daniel Lee",
            address2);

        Order order2 = new Order(customer2);

        Product product5 = new Product("Headphones", "HP410", 42.75, 1);
        Product product6 = new Product("Webcam", "WC220", 39.99, 1);
        Product product7 = new Product("Mouse Pad", "MP125", 11.50, 2);
        Product product8 = new Product("Phone Charger", "PC330", 18.25, 2);

        order2.AddProduct(product5);
        order2.AddProduct(product6);
        order2.AddProduct(product7);
        order2.AddProduct(product8);


        // Order 3 - USA customer
        Address address3 = new Address(
            "789 Oak Avenue",
            "Portland",
            "Oregon",
            "USA");

        Customer customer3 = new Customer(
            "Maria Garcia",
            address3);

        Order order3 = new Order(customer3);

        Product product9 = new Product("Notebook", "NB510", 4.75, 4);
        Product product10 = new Product("Pen Set", "PS215", 7.99, 2);
        Product product11 = new Product("Desk Lamp", "DL320", 24.50, 1);
        Product product12 = new Product("Desk Organizer", "DO425", 16.25, 1);

        order3.AddProduct(product9);
        order3.AddProduct(product10);
        order3.AddProduct(product11);
        order3.AddProduct(product12);


        // Display Order 1
        Console.WriteLine();
        Console.WriteLine("ORDER 1");
        Console.WriteLine();

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine();

        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine();

        Console.WriteLine($"Total Price: ${order1.GetTotalCost():F2}");

        Console.WriteLine();
        Console.WriteLine("------------------------------");
        Console.WriteLine();


        // Display Order 2
        Console.WriteLine("ORDER 2");
        Console.WriteLine();

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine();

        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine();

        Console.WriteLine($"Total Price: ${order2.GetTotalCost():F2}");

        Console.WriteLine();
        Console.WriteLine("------------------------------");
        Console.WriteLine();


        // Display Order 3
        Console.WriteLine("ORDER 3");
        Console.WriteLine();

        Console.WriteLine(order3.GetPackingLabel());
        Console.WriteLine();

        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order3.GetShippingLabel());
        Console.WriteLine();

        Console.WriteLine($"Total Price: ${order3.GetTotalCost():F2}");
        Console.WriteLine();
    }
}