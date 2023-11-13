using Microsoft.EntityFrameworkCore;

namespace TodoList.Entities
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Todo> Todos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("server=.\\SQLExpress;database=Todo;Trusted_Connection=True;TrustServerCertificate=true"); // todo: add connection string
        }
    }
}
