using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Binary Search in E-commerce Platform\n");

        BinarySearchEngine engine=new BinarySearchEngine();
        engine.DisplayAllProducts();

        Console.WriteLine("\n Binary Search by Price ");
        engine.SearchByPrice(29.99m);

        Console.WriteLine("\n Binary Search Another Product ");
        engine.SearchByPrice(149.99m);

        Console.WriteLine("\n Search Not Found ");
        engine.SearchByPrice(50m);

        Console.ReadLine();
    }
}
