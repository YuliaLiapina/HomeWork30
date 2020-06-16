using BusinessLogic;
using System;

namespace TodoListHomeWork30
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var todoListManager = new TodoListManager();

            var tasks = todoListManager.GetAllTasksBL();

            foreach (var task in tasks)
            {
                Console.WriteLine($"{task.Name} - {task.Status}");

                foreach (var category in task.Categories)
                {
                    Console.WriteLine($"{category.Name}");
                }
            }

            todoListManager.CheckTaskState();

            todoListManager.UpdateTaskStatus();
        }
    }
}
