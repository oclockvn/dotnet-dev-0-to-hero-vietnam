namespace OOP_Ex01;

public class Program
{
    static void Main(string[] args)
    {
        Person p1 = new Person();
        p1.SetInfo("Tri", 27, "HCM");
        Console.WriteLine($"{p1.Name} is {p1.Age} and living in {p1.Address}");

        var p2 = new Person();
        p2.SetInfo("Lucas", 27, "TD");
        Console.WriteLine($"{p2.Name} is {p2.Age} and living in {p2.Address}");
    }
}

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Address { get; set; }

    public void SetInfo(string name, int age, string address)
    {
        Name = name;
        Age = age;
        Address = address;
    }
}
