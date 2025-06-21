// See https://aka.ms/new-console-template for more information
using System;
public class Product
{
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public string Category { get; set; }

    public Product(int id, string name, string category)
    {
        ProductId = id;
        ProductName = name;
        Category = category;
    }
   
}

class Program
{
     public static int LinearSearch(Product[] products, int targetId)
    {
        for (int i = 0; i < products.Length; i++)
        {
            if (products[i].ProductId == targetId)
                return i; // Position found
        }
        return -1; // Not found
    }
    public static int BinarySearch(Product[] sortedProducts, int targetId)
{
    int left = 0;
    int right = sortedProducts.Length - 1;
    
    while (left <= right)
    {
        int mid = left + (right - left) / 2;
        int midId = sortedProducts[mid].ProductId;
        
        if (midId == targetId) return mid;
        if (midId < targetId) left = mid + 1;
        else right = mid - 1;
    }
    return -1; // Not found
}
    static void Main(string[] args)
    {
        // Your code starts here
        Console.WriteLine("Hello, e-commerce search!");

        // Example usage of your search functions
        Product[] products = {
            new Product(101, "Keyboard", "Electronics"),
            new Product(205, "Desk Lamp", "Furniture"),
            new Product(307, "Mouse", "Electronics")
        };

        // Make sure the array is sorted for binary search
        Array.Sort(products, (a, b) => a.ProductId.CompareTo(b.ProductId));

        int targetId = 205;
        int linearResult = LinearSearch(products, targetId);
        int binaryResult = BinarySearch(products, targetId);

        Console.WriteLine($"Linear Search Result: {linearResult}");
        Console.WriteLine($"Binary Search Result: {binaryResult}");
    }
}
