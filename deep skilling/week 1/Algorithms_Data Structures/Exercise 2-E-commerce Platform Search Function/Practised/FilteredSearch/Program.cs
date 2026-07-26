using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Advanced Filtered Search in E-commerce Platform\n");

        FilteredSearchEngine engine=new FilteredSearchEngine();

        engine.FilterByMultipleCriteria("Electronics",200m,4);

        Console.WriteLine("\n");
        engine.SearchHighRatedInStock();

        Console.WriteLine("\n");
        engine.FindBestValue();

        Console.ReadLine();
    }
}
