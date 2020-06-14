using System.Collections.Generic;

namespace DAL.Models
{
   public class CategoryBL
    {
        public CategoryBL()
        {
            Tasks = new List<TaskBL>();
            CompletedTasks = new List<CompletedTaskBL>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<TaskBL> Tasks { get; set; }
        public ICollection<CompletedTaskBL> CompletedTasks { get; set; }
    }
}
