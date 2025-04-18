using Microsoft.EntityFrameworkCore;

namespace TodoAPI
{
    public class TodoDb : DbContext
    {
        public DbSet<TodoItem> TodoItems { get; set; }
        public TodoDb(DbContextOptions<TodoDb> options) : base(options)
        {
        }
    }
}
