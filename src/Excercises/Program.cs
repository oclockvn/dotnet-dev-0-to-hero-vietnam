using System.Reflection;

namespace Exercises
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var types = Assembly.GetExecutingAssembly().GetTypes().Where(t => t.BaseType == typeof(BaseProj));
            Dictionary<int, BaseProj> projects = new();
            int i = 0;

            foreach (var type in types)
            {
                var instance = (BaseProj)Activator.CreateInstance(type);
                Console.WriteLine($"ID {i}: {instance.Description}");

                projects.Add(i++, instance);
            }

            var cont = true;
            do
            {
                int id = 0;
                do
                {
                    Console.Write("Enter ID: ");
                    if (int.TryParse(Console.ReadLine(), out id))
                    {
                        if (projects.ContainsKey(id))
                        {
                            break;
                        }

                        Console.WriteLine($"No item found by ID {id}. Try again!");
                    }
                } while (true);

                var project = projects[id];

                try
                {
                    Console.WriteLine($"---------------------");
                    Console.WriteLine(project.Description);
                    Console.WriteLine($"---------------------");
                    project.Run();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Something happen while running solution for {project.Description}: {ex.Message}");
                }

                Console.Write("Continue (y/n) ?");
                cont = Console.ReadLine() == "y";
            } while (cont);
        }
    }
}
