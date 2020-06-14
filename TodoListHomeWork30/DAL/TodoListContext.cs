using DAL.Models;
using System.Data.Entity;

namespace DAL
{
    public class TodoListContext : DbContext
    {
        public TodoListContext() : base("DefaultConnection")
        {
            Database.SetInitializer(new TodoListInitializer());
        }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<CompletedTask> CompletedTasks { get; set; }
    }
}
