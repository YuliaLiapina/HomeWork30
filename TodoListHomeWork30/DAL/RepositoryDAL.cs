using DAL.Interfaces;
using DAL.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace DAL
{
    public class RepositoryDAL : IRepositoryDAL
    {
        public void AddTask(Task task)
        {
            using (var ctx = new TodoListContext())
            {
                var newCompletedTask = new CompletedTask() { Name = task.Name, Status = task.Status };

                ctx.CompletedTasks.Add(newCompletedTask);

                ctx.SaveChanges();
            }
        }

        public List<Task> GetAllTasks()
        {
            using (var ctx = new TodoListContext())
            {
                return ctx.Tasks.Include(task => task.Categories).ToList();
            }
        }

        public void RemoveTask(int id)
        {
            using (var ctx = new TodoListContext())
            {
                var task = ctx.Tasks.Where(x => x.Id == id).FirstOrDefault();

                ctx.Tasks.Remove(task);

                ctx.SaveChanges();
            }
        }

        public void UpdateTaskStatus()
        {
            using (var ctx = new TodoListContext())
            {
                var tasks = ctx.Tasks.ToList();
                tasks[1].Status = "Done";

                ctx.SaveChanges();
            }
        }
    }
}
