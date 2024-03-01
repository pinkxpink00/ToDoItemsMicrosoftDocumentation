using Microsoft.EntityFrameworkCore;
using ToDoItemsMicrosoftDocumentation.Models;

namespace ToDoItemsMicrosoftDocumentation.Data
{
    public class ToDoContext : DbContext
    {
        public ToDoContext(DbContextOptions<ToDoContext> options) : base(options) { }
        public DbSet<TodoItem> TodoItems { get; set; } = null;
    }
}
