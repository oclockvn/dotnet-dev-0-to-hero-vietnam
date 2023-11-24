namespace OOP_Ex10;

//Develop a class library for managing a library system. Create classes for Book, Author, Member, and Borrowing.
//Implement methods for adding, removing, and searching for books, authors, and members.
//Manage borrowing and returning of books.

public class Program
{
    static void Main(string[] args)
    {
        //var library = new Library();
        //library.AddMember("John");
        //library.AddAuthor("Lucas");
        //library.AddBook("abc");
        //library.BorrowBook("abc", "abc");

        //Console.WriteLine(library);
        var p = new Person();
        p.Name = "abc";

        Console.WriteLine(p);
    }
}

public class Person
{
    public Guid Id { get; set; }
    public string Name { get; set; }

    public override string ToString()
    {
        return Name;
    }
}

public class Book
{
    public Guid BookId { get; set; }
    public string BookName { get; set; } = null!;
    //public Author Author { get; set; } = null!;
}

public class Author : Person
{
    
}

public class Member : Person
{
    
}

public class Borrowing
{
    public int BorrowingId { get; set; }
    public Book Book { get; set; } = null!;
    public Member Member { get; set; } = null!;
    public DateTime BorrowDate { get; set; }
    public DateTime ReturnDate { get; set; }
}



public class Library
{
    private List<Book> books = new List<Book>();
    private List<Author> authors = new List<Author>();
    private List<Member> members = new List<Member>();
    private List<Borrowing> borrowinglist = new List<Borrowing>();

    public void AddBook(string bookName)
    {
        books.Add(new Book()
        {
            BookId = Guid.NewGuid(),
            BookName = bookName,
        });
    }

    public void RemoveBook(string bookName)
    {
        var book = books.FirstOrDefault(x => x.BookName == bookName);

        if (book == null)
        {
            Console.WriteLine("No book exists.");
            return;
        }

        books.Remove(book);
    }

    public Book? SearchBook(string bookName)
    {
        var book = books.Find(x => x.BookName == bookName);

        if (book == null)
        {
            Console.WriteLine($"No book has the title {bookName} that exists in the library.");
        }

        return book;
    }

    public void AddAuthor(string author)
    {
        authors.Add(new Author()
        {
            Id = Guid.NewGuid(),
            Name = author,
        });
    }

    public void RemoveAuthor(string authorName)
    {
        var author = authors.FirstOrDefault(x => x.Name == authorName);

        if (author == null)
        {
            Console.WriteLine("No author exists.");
            return;
        }

        authors.Remove(author);
    }

    public Author? SearchAuthor(string authorName)
    {
        var author = authors.Find(x => x.Name == authorName);

        if (author == null)
        {
            Console.WriteLine($"No author has the name {authorName} that exists in the library.");
        }

        return author;
    }

    public void AddMember(string member)
    {
        members.Add(new Member
        {
            Id = Guid.NewGuid(),
            Name = member,
        });
    }

    public void RemoveMember(string memberName)
    {
        var member = members.FirstOrDefault(x => x.Name == memberName);

        if (member == null)
        {
            Console.WriteLine("No member exists.");
            return;
        }

        members.Remove(member);
    }

    public Member? SearchMember(string memberName)
    {
        var member = members.Find(x => x.Name == memberName);

        if (member == null)
        {
            Console.WriteLine($"There is no member {memberName} in the library.");
        }

        return member;
    }

    public void BorrowBook(string bookName, string memberName)
    {
        var book = books.FirstOrDefault(x => x.BookName == bookName);

        if (book == null)
        {
            Console.WriteLine("No book exists.");
            return;
        }

        var member = members.FirstOrDefault(x => x.Name == memberName);

        if (member == null)
        {
            Console.WriteLine("No member exists.");
            return;
        }

        borrowinglist.Add(new Borrowing()
        {
            Book = book,
            BorrowDate = DateTime.Now,
            BorrowingId = 0,
            Member = member,
        });
    }

    public void ReturningBook(string bookName, string memberName)
    {
        var borrowed = borrowinglist.Find(x => x.Book.BookName ==  bookName && x.Member.Name == memberName);

        if (borrowed == null)
        {
            return;
        }

        borrowinglist.Remove(borrowed);
    }
}
