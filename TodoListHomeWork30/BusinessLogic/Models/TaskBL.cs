using System.Collections.Generic;

namespace DAL.Models
{
   public class TaskBL
    {
        public TaskBL()
        {
            Categories = new List<CategoryBL>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }

        public ICollection<CategoryBL> Categories { get; set; }
    }
}
