namespace Exercises.Projects
{
    public class Proj47 : BaseProj
    {
        public override string Description => "Write a C# program to compute the sum of all the elements of an array of integers.";

        public override void Run()
        {
            var arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var sum = 0;

            foreach (var item in arr)
            {
                sum += item;
            }

            Console.WriteLine(sum);
        }
    }
}
