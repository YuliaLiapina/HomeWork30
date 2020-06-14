using System.Collections.Generic;

namespace DAL.Models
{
  public class CompletedTask
    {
        public CompletedTask()
        {
            Categories = new List<Category>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public ICollection<Category> Categories { get; set; }
    }
}
