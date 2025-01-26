using Microsoft.EntityFrameworkCore;

namespace TodoMVCApp.Models
{
    public class TodoDbContext: DbContext
    {
        public TodoDbContext(DbContextOptions<TodoDbContext> options): base(options)
        {
            
        }

        public DbSet<Todo> TodoItem { get; set; }

    }
}
