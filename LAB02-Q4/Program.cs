using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB02_Q4
{


    class Product
    {

        public string ProductName { get; set; }
        public double Price { get; set; }


        public Product(string productName, double price)
        {
            ProductName = productName;
            Price = price;
        }
    }

    class Program
    {
        static void Main()
        {

            Product product1 = new Product("Laptop", 999.99);
            Product product2 = new Product("Smartphone", 599.99);
            Product product3 = new Product("Tablet", 299.99);


            Console.WriteLine("Product Details:");
            Console.WriteLine($"Product Name: {product1.ProductName}, Price: ${product1.Price}");
            Console.WriteLine($"Product Name: {product2.ProductName}, Price: ${product2.Price}");
            Console.WriteLine($"Product Name: {product3.ProductName}, Price: ${product3.Price}");
            Console.ReadLine();

        }
    }
