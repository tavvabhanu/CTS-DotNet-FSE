using System;

public class Product
{
    public int Id;
    public string Name;
    public decimal Price;
    public int Stock;
    public string Category;

    public Product(int id, string name, decimal price, int stock, string category)
    {
        Id=id;
        Name=name;
        Price=price;
        Stock=stock;
        Category=category;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"ID: {Id} | {Name} | Price: ${Price:F2} | Stock: {Stock} | Category: {Category}");
    }
}
