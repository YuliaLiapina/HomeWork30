using BusinessLogic;
using DAL.Models;
using System;
using System.Collections.Generic;

namespace TodoListHomeWork30
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var todoListManager = new TodoListManager();

            List<TaskBL> tasks = todoListManager.GetAllTasksBL();

            foreach (var item in tasks)
            {
                Console.WriteLine($"{item.Name} - {item.Status}");
            }

            todoListManager.CheckTaskState();

            todoListManager.UpdateTaskStatus();
        }
    }
}
