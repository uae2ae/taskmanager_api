using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace taskmanager_api.DTOs.Task
{
    public class GetTasksDto
    {
        public int Id {get; set;}
        public int CreatorId {get; set;}
        public string TaskTitle { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string[] ?Tags {get; set;}
        public string[] ?AssignedUsers {get; set;}
        public DateTime CreatedAt { get; set; }
        public DateTime DueDate { get; set; }
    }
}