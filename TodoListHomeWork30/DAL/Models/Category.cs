using System.Collections.Generic;

namespace DAL.Models
{
   public class Category
    {
        public Category()
        {
            Tasks = new List<Task>();
            CompletedTasks = new List<CompletedTask>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Task> Tasks { get; set; }
        public ICollection<CompletedTask> CompletedTasks { get; set; }
    }
}
