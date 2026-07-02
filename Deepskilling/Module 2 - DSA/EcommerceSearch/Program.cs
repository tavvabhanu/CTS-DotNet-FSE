using System;

namespace EcommerceSearchExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Product[] products =
            {
                new Product(101, "Laptop", "Electronics"),
                new Product(102, "Mobile", "Electronics"),
                new Product(103, "Shoes", "Fashion"),
                new Product(104, "Watch", "Accessories"),
                new Product(105, "Headphones", "Electronics")
            };

            Console.WriteLine("Linear Search:");

            Product result1 = SearchAlgorithms.LinearSearch(products, 104);

            if (result1 != null)
                result1.Display();
            else
                Console.WriteLine("Product not found.");

            Console.WriteLine();

            Console.WriteLine("Binary Search:");

            Product result2 = SearchAlgorithms.BinarySearch(products, 104);

            if (result2 != null)
                result2.Display();
            else
                Console.WriteLine("Product not found.");

            Console.ReadLine();
        }
    }
}