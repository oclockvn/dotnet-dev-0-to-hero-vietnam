using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoList.DTOs;
using TodoList.Entities;

namespace TodoList.Services
{
    interface ITodoService
    {
        Task<List<TodoDTO>> GetTodosAsync();
        Task<TodoDTO?> GetTodoAsync(int id);
        Task<TodoDTO> AddTaskAsync(string name);
        Task CompleteAsync(int id);
        Task DeleteTaskAsync(int id);
    }

    public class TodoService : ITodoService
    {
        private ApplicationDbContext applicationDbContext = new();

        public async Task<List<TodoDTO>> GetTodosAsync()
        {
            var todos = await applicationDbContext.Todos.Select(todo => new TodoDTO()
            {
                Id = todo.Id,
                Name = todo.Name,
                Completed = todo.Completed,
            }).ToListAsync();
            //List<TodoDTO> list = new();
            //list.Add(new TodoDTO());
            return todos;
        }

        public async Task<TodoDTO?> GetTodoAsync(int id)
        {
            return await applicationDbContext.Todos
                .Where(x => x.Id == id)
                .Select(x => new TodoDTO() 
                { 
                    Id = x.Id,
                    Name = x.Name,
                    Completed = x.Completed,
                }).FirstOrDefaultAsync();
        }

        public async Task<TodoDTO> AddTaskAsync(string name)
        {
            var todo = new Todo();
            todo.Name = name;
            todo.Completed = false;

            applicationDbContext.Todos.Add(todo);
            var count = await applicationDbContext.SaveChangesAsync();

            if (count == 0)
            {
                throw new Exception("Cannot save changes.");
            }

            return new TodoDTO
            {
                Id=todo.Id,
                Name = todo.Name,
                Completed = todo.Completed,
            };
        }

        public async Task CompleteAsync(int id)
        {
           var todo = await applicationDbContext.Todos.FirstOrDefaultAsync(x => x.Id == id);

            if (todo == null)
            {
                throw new Exception($"No Todo found by Id {id}");
            }

            todo.Completed = true;
            await applicationDbContext.SaveChangesAsync();
        }

        public async Task DeleteTaskAsync(int id)
        {
            var todo= await applicationDbContext.Todos.FirstOrDefaultAsync( x => x.Id == id);

            applicationDbContext.Todos.Remove(todo);
            await applicationDbContext.SaveChangesAsync();
        }
    }
}
