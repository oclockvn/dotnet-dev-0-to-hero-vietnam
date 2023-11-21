using System.Threading.Channels;
using TodoList.DTOs;
using TodoList.Services;

namespace TodoList
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            var again = true;
            while (again)
            {
                Console.WriteLine("My todos: ");
                Console.WriteLine("1. List all todos");
                Console.WriteLine("2. Add new todo");
                Console.WriteLine("3. Complete todo");

                var num = GetNumber("Please choose: ");

                if (num == 1)
                {
                    await ShowTodoAsync();
                }
                else if (num == 2)
                {
                    await AddTodoAsync();
                }

                Console.WriteLine("Continue (y/n)");
                again = Console.ReadLine() == "y";
            }

        }

        static async Task AddTodoAsync()
        {
            ITodoService service = new TodoService();
            await Console.Out.WriteLineAsync("Enter your todo: ");
            var name = Console.ReadLine();

            var result = await service.AddTaskAsync(name);

            if (result?.Id > 0)
            {
                await Console.Out.WriteLineAsync("Add successfully.");
            }
            else
            {
                await Console.Out.WriteLineAsync("Something went wrong.");
            }
        }

        static async Task ShowTodoAsync()
        {
            ITodoService service = new TodoService();
            var todos = await service.GetTodosAsync();

            foreach (var todo in todos)
            {
                var status = todo.Completed ? "[Done]" : "[Todo]";
                Console.WriteLine($"{status}-{todo.Name}");
            }
        }

        static async Task TodoCompleteAsync(int id)
        {
            ITodoService service = new TodoService();
            await Console.Out.WriteLineAsync("Please enter id: ");
            var n = Console.ReadLine();

            await service.CompleteAsync(int.Parse(n));
        }

        static int GetNumber(string message)
        {
            while (true)
            {
                Console.WriteLine(message);
                if (int.TryParse(Console.ReadLine(), out var number))
                {
                    if (number >= 1 && number <= 3)
                    {
                        return number;
                    }
                }
            }
        }
    }
}
