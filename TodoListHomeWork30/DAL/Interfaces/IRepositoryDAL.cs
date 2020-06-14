using DAL.Models;
using System.Collections.Generic;

namespace DAL.Interfaces
{
    public interface IRepositoryDAL
    {
        void AddTask(Task task);
        void RemoveTask(int id);
        List<Task> GetAllTasks();
        void UpdateTaskStatus();
    }
}
