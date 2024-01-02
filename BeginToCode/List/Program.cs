namespace List;

public class Program
{
    static void Main(string[] args)
    {
        DayOfWeek weeken = (DayOfWeek)1;
    }

    public struct Person
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public DayOfWeek Weeken { get; set; }
    }

    public enum DayOfWeek
    {
        Sunday = 1,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
    }
}
