using Microsoft.EntityFrameworkCore;

namespace TodoApi.Models
{
    public class TodoItemContext : DbContext 
    {
        public DbSet<TodoItem> TodoItems { get; set; }
        public TodoItemContext(DbContextOptions<TodoItemContext> options) : base(options) { }
    }
}
