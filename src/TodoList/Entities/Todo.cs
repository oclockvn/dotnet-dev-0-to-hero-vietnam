namespace TodoList.Entities
{
    public class Todo
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Completed { get; set; }
    }
}
