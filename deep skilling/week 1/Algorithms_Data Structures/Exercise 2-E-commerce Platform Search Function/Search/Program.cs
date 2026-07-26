using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("E-commerce Platform Search Function\n");

        EcommerceSearch store=new EcommerceSearch();

        store.DisplayAllProducts();

        Console.WriteLine("\n Linear Search ");
        store.LinearSearch("Laptop");

        Console.WriteLine("\n Search by Category ");
        store.SearchByCategory("Electronics");

        Console.WriteLine("\n Search by Price Range ");
        store.SearchByPriceRange(20m, 100m);

        Console.ReadLine();
    }
}
