using System;
using System.Collections.Generic;
using System.Linq;

public class AdvancedProduct
{
    public int Id;
    public string Name;
    public decimal Price;
    public string Category;
    public int Rating;
    public int Stock;

    public AdvancedProduct(int id, string name, decimal price, string category, int rating, int stock)
    {
        Id=id;
        Name=name;
        Price=price;
        Category=category;
        Rating=rating;
        Stock=stock;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"ID: {Id} | {Name} | Price: ${Price:F2} | Category: {Category} | Rating: {Rating}/5 | Stock: {Stock}");
    }
}

public class FilteredSearchEngine
{
    private List<AdvancedProduct> products;

    public FilteredSearchEngine()
    {
        products=new List<AdvancedProduct>
        {
            new AdvancedProduct(1,"Laptop HP",899.99m,"Electronics",5,15),
            new AdvancedProduct(2,"Mouse Logitech",29.99m,"Electronics",4,50),
            new AdvancedProduct(3,"Keyboard Mechanical",79.99m,"Electronics",5,30),
            new AdvancedProduct(4,"Monitor LG",299.99m,"Electronics",4,20),
            new AdvancedProduct(5,"USB Cable",9.99m,"Accessories",3,100),
            new AdvancedProduct(6,"Phone Samsung",699.99m,"Electronics",5,25),
            new AdvancedProduct(7,"Headphones Sony",149.99m,"Electronics",5,40),
            new AdvancedProduct(8,"Screen Protector",4.99m,"Accessories",2,200),
            new AdvancedProduct(9,"Phone Case",19.99m,"Accessories",4,150),
            new AdvancedProduct(10,"Charger Fast",39.99m,"Accessories",4,80)
        };
    }

    public void FilterByMultipleCriteria(string category, decimal maxPrice, int minRating)
    {
        Console.WriteLine($"Filtering by: Category={category}, Max Price=${maxPrice:F2}, Min Rating={minRating}/5\n");
        var filtered=products.Where(p=>
            p.Category.ToLower()==category.ToLower()&&
            p.Price<=maxPrice&&
            p.Rating>=minRating).ToList();

        if(filtered.Count==0)
        {
            Console.WriteLine("No products match the criteria");
            return;
        }

        foreach(var product in filtered)
        {
            product.DisplayInfo();
        }
    }

    public void SearchHighRatedInStock()
    {
        Console.WriteLine("High Rated Products with Good Stock:\n");
        var highRated=products.Where(p=>p.Rating>=4&&p.Stock>=20).OrderByDescending(p=>p.Rating).ToList();

        foreach(var product in highRated)
        {
            product.DisplayInfo();
        }
    }

    public void FindBestValue()
    {
        Console.WriteLine("Best Value Products (High Rating, Low Price):\n");
        var bestValue=products.Where(p=>p.Price<=100&&p.Rating>=4).OrderByDescending(p=>p.Rating).ThenBy(p=>p.Price).ToList();

        foreach(var product in bestValue)
        {
            product.DisplayInfo();
        }
    }
}
