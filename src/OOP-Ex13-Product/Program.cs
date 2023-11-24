namespace OOP_Ex13_Product;

public class Program
{
    static void Main(string[] args)
    {
        var product = new Product("Banana", 1.1, 13);

        product.PrintProduct();
    }
}

public class Product
{
    private readonly string name;
    private readonly double price;
    private readonly int quantity;

    public Product(string name, double price, int quantity)
    {
        this.name = name;
        this.price = price;
        this.quantity = quantity;
    }

    public void PrintProduct()
    {
        Console.WriteLine($"{name} : {price} : {quantity} pcs");
    }
}
