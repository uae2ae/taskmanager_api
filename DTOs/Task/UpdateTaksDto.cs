using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace taskmanager_api.DTOs.Task
{
    public class UpdateTasksDto
    {
        public string TaskTitle { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string[] ?Tags {get; set;}
        public string[] ?AssignedUsers {get; set;}
        public DateTime DueDate { get; set; }
    }
}