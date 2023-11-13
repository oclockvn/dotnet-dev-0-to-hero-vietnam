namespace Exercises.Projects
{
    public class Proj29 : BaseProj
    {
        public override string Description => "Write a C# program to find the size of a specified file in bytes.";

        public override void Run()
        {
            var path = GetPath("Please enter a file path: ");
            var fileInfo = new FileInfo(path);
            var size = fileInfo.Length;

            if (!fileInfo.Exists)
            {
                Console.WriteLine("Error: File not found.");
            }

            Console.WriteLine($"The size of file in bytes is : {size}");
        }

        public string GetPath(string message)
        {
            while (true)
            {
                Console.WriteLine(message);
                var path = Console.ReadLine();
                if (path.Length != 0)
                {
                    return path;
                }
            }
        }
    }
}
