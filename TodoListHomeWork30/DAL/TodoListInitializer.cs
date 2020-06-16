using DAL.Models;
using System.Collections.Generic;
using System.Data.Entity;

namespace DAL
{
    public class TodoListInitializer : DropCreateDatabaseAlways<TodoListContext>
    {
        protected override void Seed(TodoListContext context)
        {
            var category1 = new Category() { Name = "Category1" };
            var category2 = new Category() { Name = "Category2" };
            var category3 = new Category() { Name = "Category3" };

            var listOfCategories1 = new List<Category>();
            listOfCategories1.Add(category1);
            listOfCategories1.Add(category2);
            listOfCategories1.Add(category3);

            var listOfCategories2 = new List<Category>();
            listOfCategories1.Add(category1);
            listOfCategories1.Add(category3);

            var listOfCategories3 = new List<Category>();
            listOfCategories3.Add(category2);

            var task1 = new Task() { Name = "Task1", Status = "Processing", Categories = listOfCategories1 };
            var task2 = new Task() { Name = "Task2", Status = "Processing", Categories = listOfCategories2 };
            var task3 = new Task() { Name = "Task3", Status = "Done", Categories = listOfCategories3 };

            context.Categories.AddRange(listOfCategories1);

            context.Tasks.Add(task1);
            context.Tasks.Add(task2);
            context.Tasks.Add(task3);

            context.SaveChanges();
        }
    }
}
