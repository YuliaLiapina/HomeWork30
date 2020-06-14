using DAL.Models;
using System.Data.Entity;

namespace DAL
{
    public class TodoListInitializer : CreateDatabaseIfNotExists<TodoListContext>
    {
        protected override void Seed(TodoListContext context)
        {
            var category1 = new Category() { Name = "Category1" };
            var category2 = new Category() { Name = "Category2" };
            var category3 = new Category() { Name = "Category3" };

            var task1 = new Task() { Name = "Task1", Status = "Processing" };
            var task2 = new Task() { Name = "Task2", Status = "Processing" };
            var task3 = new Task() { Name = "Task3", Status = "Done" };

            context.Categories.Add(category1);
            context.Categories.Add(category2);
            context.Categories.Add(category3);

            context.Tasks.Add(task1);
            context.Tasks.Add(task2);
            context.Tasks.Add(task3);

            context.SaveChanges();
        }
    }
}
