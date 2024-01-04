namespace ReadFile
{
    public class Program
    {
        static void Main(string[] args)
        {
            var path = "C:\\Users\\phanc\\projects\\dotnet-dev-0-to-hero-vietnam\\MOCK_DATA.csv";
            string outputFile = "OutputInfo.txt";

            try
            {
                string[] lines = File.ReadAllLines(path);

                using (StreamWriter writer = new StreamWriter(outputFile))
                {
                    foreach (var line in lines)
                    {
                        string[] infos = line.Split(',');

                        if (DateTime.TryParse(infos[3], out var birthtday))
                        {
                            var age = DateTime.Now.Year - birthtday.Year;
                            if (age > 18)
                            {
                                Console.WriteLine($"{infos[1]} {infos[2]} is {age} years old.");
                            }
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                throw new Exception();
            }
        }
    }
}
