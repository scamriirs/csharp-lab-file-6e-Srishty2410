//Write a program to show the concept of read and write properties

using System;

class Product
{
    private string name;
    private double price;

    public string Name
    {
        set { name = value; }
    }

    public double Price
    {
        get { return price; }
        set { price = value; }
    }

    public string Description
    {
        get { return $"Product: {name}, Price: {price:C}"; }
    }
}

class Program
{
    static void Main()
    {
        Product product = new Product();

        product.Name = "Laptop";
        product.Price = 75000;

        Console.WriteLine($"Price: {product.Price}");
        Console.WriteLine(product.Description);

    }
}
