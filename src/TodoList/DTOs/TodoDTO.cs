using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoList.DTOs
{
    public class TodoDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Completed { get; set; }
    }
}
