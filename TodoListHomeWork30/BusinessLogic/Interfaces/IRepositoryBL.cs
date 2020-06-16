using DAL.Models;
using System.Collections.Generic;

namespace BusinessLogic.Interfaces
{
    public interface IRepositoryBL
    {
        void CheckTaskState();

        IList<TaskBL> GetAllTasksBL();
    }
}
