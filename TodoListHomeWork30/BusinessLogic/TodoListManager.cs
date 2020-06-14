using BusinessLogic.Interfaces;
using DAL;
using DAL.Interfaces;
using DAL.Models;
using System.Collections.Generic;

namespace BusinessLogic
{
    public class TodoListManager : IRepositoryBL
    {
        private readonly IRepositoryDAL todoListRepository;
        public TodoListManager()
        {
            todoListRepository = new RepositoryDAL();
        }

        public void CheckTaskState()
        {
            var taskList = todoListRepository.GetAllTasks();

            foreach (var task in taskList)
            {
                if (task.Status == "Done")
                {
                    todoListRepository.AddTask(task);

                    todoListRepository.RemoveTask(task.Id);
                }
            }
        }
        public List<TaskBL> GetAllTasksBL()
        {
            var tasks = todoListRepository.GetAllTasks();

            TaskBL taskBl = new TaskBL();

            List<TaskBL> tasksBl = new List<TaskBL>();

            foreach (var item in tasks)
            {
                taskBl.Name = item.Name;
                taskBl.Status = item.Status;
                tasksBl.Add(taskBl);
            }

            return tasksBl;
        }

        public void UpdateTaskStatus()
        {
            todoListRepository.UpdateTaskStatus();
        }
    }
}
