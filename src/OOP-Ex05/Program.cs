namespace OOP_Ex05;

public class Program
{
    static void Main(string[] args)
    {
        var b1 = new Book()
        {
            Title = "abc",
            Author = "xyz",
            Genre = "dhf",
            NumberOfPages = 1,
        };

        Console.WriteLine($"The author of {b1.Title} is {b1.Author}. This book is belong to {b1.Genre} type and it has {b1.NumberOfPages} pages.");
    }
}

public class Book
{
    public string Title { get; set; } = null!;
    public string Author { get; set; } = null!;
    public string Genre { get; set; } = null!;
    public int NumberOfPages { get; set; }
}
