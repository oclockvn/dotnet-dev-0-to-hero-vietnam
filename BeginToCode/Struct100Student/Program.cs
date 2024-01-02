namespace Struct100Student
{
    public class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[10];

            for (int i = 0; i < students.Length; i++)
            {
                Console.Write($"Please enter student's name {i + 1}: ");
                var name = Console.ReadLine();

                Console.Write($"Please enter student's address {i + 1}: ");
                var address = Console.ReadLine();

                var score = GetScore($"Please enter student's score {i + 1}:");

                students[i] = new Student { Name = name, Score = score };
            }

            Console.WriteLine();
            foreach (var student in students)
            {
                Console.WriteLine($"Student: {student.Name}, Score: {student.Score}, Address: {student.Address}");
            }
        }

        static double GetScore(string message)
        {
            while (true)
            {
                Console.Write(message);
                if (double.TryParse(Console.ReadLine(), out var score))
                {
                    return score;
                }
            }
        }

        struct Student
        {
            public string Name { get; set; }
            public double Score { get; set; }
            public string Address {  get; set; }
        }
    }
}
