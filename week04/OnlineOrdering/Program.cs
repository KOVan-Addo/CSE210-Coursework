
using System;

class Program
{
    static void Main(string[] args)
    {
        //Creativity - though not required for this week, 
       // To allow for my local currency (the cedi) code
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        // ORDER 1: Customer in the USA

        Address address1 = new Address(
            "119 Salt lake",
            "Utah",
            "UT",
            "USA"
        );

        Customer customer1 = new Customer(
            "Kelvin Offei",
            address1
        );

        Order order1 = new Order(customer1);

        Product product1 = new Product(
            "Laptop",
            "LAP001",
            750.00,
            2
        );

        Product product2 = new Product(
            "Wireless Mouse",
            "MOU002",
            25.00,
            1
        );

        Product product3 = new Product(
            "Keyboard",
            "KEY003",
            45.00,
            1
        );

        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);


        // ORDER 2: Customer in Ghana

        Address address2 = new Address(
            "15 Liberation Road",
            "Accra",
            "Greater Accra",
            "Ghana"
        );

        Customer customer2 = new Customer(
            "Ama Mensah",
            address2
        );

        Order order2 = new Order(customer2);

        Product product4 = new Product(
            "Smartphone",
            "PHO004",
            500.00,
            1
        );

        Product product5 = new Product(
            "Headphones",
            "HEA005",
            80.00,
            2
        );

        Product product6 = new Product(
            "Phone Case",
            "CAS006",
            15.00,
            3
        );

        order2.AddProduct(product4);
        order2.AddProduct(product5);
        order2.AddProduct(product6);


        // DISPLAY ORDER 1

        Console.WriteLine("========================================");
        Console.WriteLine("ORDER 1");
        Console.WriteLine("========================================");

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine();

        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine();

        Console.WriteLine($"Total Order Cost: ${order1.GetTotalCost():F2}");


        // DISPLAY ORDER 2

        Console.WriteLine("\n========================================");
        Console.WriteLine("ORDER 2");
        Console.WriteLine("========================================");

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine();

        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine();

        Console.WriteLine($"Total Order Cost: ₵{order2.GetTotalCost():F2}");

        Console.WriteLine("\n========================================");
        Console.WriteLine("END OF ORDER SUMMARY");
        Console.WriteLine("========================================");
    }
}
