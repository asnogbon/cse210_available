using System;

namespace OnlineOrdering
{
    class Program
    {
        static void Main(string[] args)
        {
            Address address1 = new Address("123 Main St", "Rexburg", "ID", "USA");
            Customer customer1 = new Customer("John Doe", address1);
            Order order1 = new Order(customer1);

            Product prod1 = new Product("Wireless Mouse", "M102", 25.50, 2);
            Product prod2 = new Product("Mechanical Keyboard", "K405", 75.00, 1);

            order1.AddProduct(prod1);
            order1.AddProduct(prod2);

            Address address2 = new Address("Av. University Ave", "Cumana", "Sucre", "Venezuela");
            Customer customer2 = new Customer("Maria Rodriguez", address2);
            Order order2 = new Order(customer2);

            Product prod3 = new Product("USB-C Hub", "H990", 19.99, 3);
            Product prod4 = new Product("HD Webcam", "W500", 45.00, 1);
            Product prod5 = new Product("Laptop Stand", "S200", 29.95, 1);

            order2.AddProduct(prod3);
            order2.AddProduct(prod4);
            order2.AddProduct(prod5);

            Console.WriteLine("===================================================");
            Console.WriteLine("                ONLINE ORDER SYSTEM                ");
            Console.WriteLine("===================================================\n");

            Console.WriteLine(">>> DISPLAY ORDER #1 <<<");
            Console.WriteLine(order1.GetPackingLabel());
            Console.WriteLine(order1.GetShippingLabel());
            Console.WriteLine($"Total Price: ${order1.CalculateTotalCost():0.00}");
            Console.WriteLine("\n------------------------------------------------------");

            Console.WriteLine(">>> DISPLAY ORDER #2 <<<");
            Console.WriteLine(order2.GetPackingLabel());
            Console.WriteLine(order2.GetShippingLabel());
            Console.WriteLine($"Total Price: ${order2.CalculateTotalCost():0.00}");
            Console.WriteLine("====================================================");
        }
    }
}