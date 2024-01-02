namespace Struct
{
    public class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[6];

            students[0] = new Student() { Name = "John", Score = 8 };
            students[1] = new Student() { Name = "Lucas", Score = 10 };
            students[2] = new Student() { Name = "Win", Score = 9 };
            students[3] = new Student() { Name = "Bright", Score = 8 };
            students[4] = new Student() { Name = "Jam", Score = 9 };
            students[5] = new Student() { Name = "Apo", Score = 9.5 };

            foreach ( var student in students)
            {
                Console.WriteLine($"Name: {student.Name}, Score: {student.Score}");
            }
        }

        struct Student
        {
            public string Name { get; set; }
            public double Score { get; set; }
        }
    }
}
