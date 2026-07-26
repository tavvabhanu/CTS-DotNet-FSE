using System;
using System.Collections.Generic;
using System.Linq;

public class BinarySearchProduct:IComparable<BinarySearchProduct>
{
    public int Id;
    public string Name;
    public decimal Price;

    public BinarySearchProduct(int id, string name, decimal price)
    {
        Id=id;
        Name=name;
        Price=price;
    }

    public int CompareTo(BinarySearchProduct other)
    {
        return this.Price.CompareTo(other.Price);
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"ID: {Id} | {Name} | Price: ${Price:F2}");
    }
}

public class BinarySearchEngine
{
    private List<BinarySearchProduct> products;

    public BinarySearchEngine()
    {
        products=new List<BinarySearchProduct>
        {
            new BinarySearchProduct(1,"USB Cable",9.99m),
            new BinarySearchProduct(2,"Screen Protector",4.99m),
            new BinarySearchProduct(3,"Phone Case",19.99m),
            new BinarySearchProduct(4,"Mouse Logitech",29.99m),
            new BinarySearchProduct(5,"Charger Fast",39.99m),
            new BinarySearchProduct(6,"Headphones Sony",149.99m),
            new BinarySearchProduct(7,"Keyboard Mechanical",79.99m),
            new BinarySearchProduct(8,"Monitor LG 27inch",299.99m),
            new BinarySearchProduct(9,"Phone Samsung",699.99m),
            new BinarySearchProduct(10,"Laptop HP",899.99m)
        };
        products.Sort();
    }

    public void SearchByPrice(decimal targetPrice)
    {
        Console.WriteLine($"Binary Search for price: ${targetPrice:F2}");
        int result=BinarySearch(targetPrice, 0, products.Count-1);
        if(result!=-1)
        {
            Console.WriteLine("Found:");
            products[result].DisplayInfo();
        }
        else
        {
            Console.WriteLine("Product not found at this price");
        }
    }

    private int BinarySearch(decimal target, int left, int right)
    {
        while(left<=right)
        {
            int mid=left+(right-left)/2;
            if(products[mid].Price==target)
                return mid;
            if(products[mid].Price<target)
                left=mid+1;
            else
                right=mid-1;
        }
        return -1;
    }

    public void DisplayAllProducts()
    {
        Console.WriteLine("Products sorted by Price:");
        foreach(var product in products)
        {
            product.DisplayInfo();
        }
    }
}
