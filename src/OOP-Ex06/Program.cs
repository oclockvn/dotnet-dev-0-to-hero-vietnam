namespace OOP_Ex06;

public class Program
{
    static void Main(string[] args)
    {
        var p1 = new ShoppingCart();
        p1.AddProduct(new Product
        {
            Name = "Phone",
            Price = 2,
            Quatity = 5,
        });

        p1.AddProduct(new Product
        {
            Name = "Ipad",
            Price = 4,
            Quatity = 3,
        });

        p1.AddProduct(new Product
        {
            Name = "tool",
            Price = 5,
            Quatity = 18,
        });

        p1.RemoveProduct("tool");
        var total = p1.GetTotal();

        Console.WriteLine(total);
    }
}

public class Product
{
    public string Name { get; set; } = null!;
    public double Price { get; set; }
    public int Quatity { get; set; }
}

public class ShoppingCart
{
    private List<Product> products = new List<Product>();

    public void AddProduct(Product p)
    {
        products.Add(p);
    }

    public void RemoveProduct(string name)
    {
        var product = products.FirstOrDefault(p => p.Name == name);
        if (product != null)
        {
            products.Remove(product);
        }
    }

    public double GetTotal()
    {
        return products.Select(p => p.Price * p.Quatity).Sum();

        //var sum = 0D;
        //foreach (var item in products)
        //{
        //    sum += item.Price;
        //}
        //return sum;
    }
}
