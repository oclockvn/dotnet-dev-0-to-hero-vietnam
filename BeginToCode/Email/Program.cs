using System.IO.IsolatedStorage;

namespace Email
{
    public class Program
    {
        static void Main(string[] args)
        {
            var path = "data.csv";

            try
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        if (line != null)
                        {
                            string[] infos = line.Split(',');

                            if (int.TryParse(infos[3], out var balance))
                            {
                                string email = infos[2].Trim();

                                if (balance < 80)
                                {
                                    Console.WriteLine($"{email}");
                                }
                            }
                            else
                            {
                                Console.WriteLine($"Invalid balance: {line}");
                            }
                        }
                    }

                   
                }
            }
            catch (Exception)
            {

                //throw null;
            }
        }
    }
}
