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
    public class TodoService
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

        public async Task<bool> AddTaskAsync(string name)
        {
            applicationDbContext.Todos.Add(new Todo() { Name = name, Completed = false });
            var count = await applicationDbContext.SaveChangesAsync();

            return count > 0;
        }

        public async Task CompleteAsync(int Id)
        {

        }
    }
}
