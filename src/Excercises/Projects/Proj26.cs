namespace Exercises.Projects
{
    public class Proj26 : BaseProj
    {
        public override string Description => "Write a C# program to compute the sum of the first 500 prime numbers.";

        public override void Run()
        {
            var sum = 0;
            var count = 0;
            var number = 2;
            var arr = new int[500];

            while (count < 500)
            {
                if (isPrime(number))
                {
                    sum += number;
                    // arr[count] = number; // add prime number into array
                    count++;
                }
                number++;
            }
            Console.WriteLine($"Sum of the first 500 prime numbers is :{sum}");
            // Console.WriteLine(string.Join(',', arr)); // print the first 500 prime numbers
        }

        public bool isPrime(int number)
        {
            if (number <= 1)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
