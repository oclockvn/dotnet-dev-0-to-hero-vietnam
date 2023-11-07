using System.Reflection;

namespace Exercises
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var items = Assembly.GetExecutingAssembly().GetTypes().Where(t => t.BaseType == typeof(BaseItem));
            Dictionary<int, BaseItem> types = new();
            int i = 0;

            foreach (var type in items)
            {
                var instance = (BaseItem)Activator.CreateInstance(type);
                Console.WriteLine($"ID {i}: {instance.Description}");

                types.Add(i++, instance);
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
                        if (types.ContainsKey(id))
                        {
                            break;
                        }

                        Console.WriteLine($"No item found by ID {id}. Try again!");
                    }
                } while (true);

                var item = types[id];

                try
                {
                    Console.WriteLine($"---------------------");
                    Console.WriteLine(item.Description);
                    Console.WriteLine($"---------------------");
                    item.Run();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Something happen while running solution for: {item.Description}");
                }

                Console.Write("Continue (y/n) ?");
                cont = Console.ReadLine() == "y";
            } while (cont);
        }
    }
}
