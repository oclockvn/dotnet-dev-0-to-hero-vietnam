namespace Exercises.Projects
{
    public class Proj46 : BaseProj
    {
        public override string Description => "Write a C# program to check if a number appears as the first or last element of an array of integers. The array length is 1 or more.";

        public override void Run()
        {
            var arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9};
            var num = GetNumber("Please enter a number: ");
            if ((num == arr[0]) || (num == arr[arr.Length - 1]))
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }


        }

        public int GetNumber(string message)
        {
            while (true)
            {
                Console.WriteLine(message);
                if (int.TryParse(Console.ReadLine(), out var number))
                {
                    return number;
                }
            }
        }
    }
}
