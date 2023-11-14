using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using taskmanager_api.DTOs.Task;

namespace taskmanager_api.Services.TaskService
{
    public interface ITaskService
    {
        Task<ServiceResponse<List<GetTasksDto>>> GetTasks();
    }
}