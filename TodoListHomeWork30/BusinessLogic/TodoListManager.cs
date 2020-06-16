using AutoMapper;
using BusinessLogic.Interfaces;
using DAL;
using DAL.Interfaces;
using DAL.Models;
using System.Collections.Generic;

namespace BusinessLogic
{
    public class TodoListManager : IRepositoryBL
    {
        public readonly Mapper _mapper;

        private readonly IRepositoryDAL todoListRepository;
        public TodoListManager()
        {
            todoListRepository = new RepositoryDAL();

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Task, TaskBL>();
                cfg.CreateMap<Category, CategoryBL>();
                cfg.CreateMap<CompletedTask, CompletedTaskBL>();
            });

            _mapper = new Mapper(config);
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
        public IList<TaskBL> GetAllTasksBL()
        {
            var tasks = todoListRepository.GetAllTasks();

            return _mapper.Map<IList<TaskBL>>(tasks);

            //var tasks = todoListRepository.GetAllTasks();

            //TaskBL taskBl = new TaskBL();
            //CategoryBL categoryBL = new CategoryBL();

            //List<TaskBL> tasksBl = new List<TaskBL>();

            //foreach (var task in tasks)
            //{
            //    taskBl.Name = task.Name;
            //    taskBl.Status = task.Status;
            //    tasksBl.Add(taskBl);

            //    foreach (var category in task.Categories)
            //    {
            //        categoryBL.Name = category.Name;
            //        taskBl.Categories.Add(categoryBL);
            //    }
            //    tasksBl.Add(taskBl);
            //}

            //return tasksBl;
        }

        public void UpdateTaskStatus()
        {
            todoListRepository.UpdateTaskStatus();
        }
    }
}
