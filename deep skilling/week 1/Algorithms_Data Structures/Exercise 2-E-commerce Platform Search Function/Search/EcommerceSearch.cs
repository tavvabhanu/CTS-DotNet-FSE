using System;
using System.Collections.Generic;
using System.Linq;

public class EcommerceSearch
{
    private List<Product> products;

    public EcommerceSearch()
    {
        products=new List<Product>
        {
            new Product(1,"Laptop HP",899.99m,15,"Electronics"),
            new Product(2,"Mouse Logitech",29.99m,50,"Electronics"),
            new Product(3,"Keyboard Mechanical",79.99m,30,"Electronics"),
            new Product(4,"Monitor LG 27inch",299.99m,20,"Electronics"),
            new Product(5,"USB Cable",9.99m,100,"Accessories"),
            new Product(6,"Phone Samsung",699.99m,25,"Electronics"),
            new Product(7,"Headphones Sony",149.99m,40,"Electronics"),
            new Product(8,"Screen Protector",4.99m,200,"Accessories"),
            new Product(9,"Phone Case",19.99m,150,"Accessories"),
            new Product(10,"Charger Fast",39.99m,80,"Accessories")
        };
    }

    public void LinearSearch(string productName)
    {
        Console.WriteLine($"Searching for: {productName}");
        int searchCount=0;
        foreach(var product in products)
        {
            searchCount++;
            if(product.Name.ToLower().Contains(productName.ToLower()))
            {
                Console.WriteLine("Found:");
                product.DisplayInfo();
                return;
            }
        }
        Console.WriteLine($"Product not found after {searchCount} searches");
    }

    public void DisplayAllProducts()
    {
        Console.WriteLine("All Products in Store:");
        foreach(var product in products)
        {
            product.DisplayInfo();
        }
    }

    public void SearchByCategory(string category)
    {
        Console.WriteLine($"Products in {category}:");
        var categoryProducts=products.Where(p=>p.Category.ToLower()==category.ToLower()).ToList();
        if(categoryProducts.Count==0)
        {
            Console.WriteLine("No products found in this category");
            return;
        }
        foreach(var product in categoryProducts)
        {
            product.DisplayInfo();
        }
    }

    public void SearchByPriceRange(decimal minPrice, decimal maxPrice)
    {
        Console.WriteLine($"Products between ${minPrice:F2} and ${maxPrice:F2}:");
        var priceProducts=products.Where(p=>p.Price>=minPrice&&p.Price<=maxPrice).ToList();
        if(priceProducts.Count==0)
        {
            Console.WriteLine("No products in this price range");
            return;
        }
        foreach(var product in priceProducts)
        {
            product.DisplayInfo();
        }
    }
}
