using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace taskmanager_api.Models
{
    public class Taks
    {
        public int Id {get; set;}
        public int CreatorId {get; set;}
        public string TaskTitle { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public string[] ?Tags {get; set;}
        public string[] ?AssignedUsers {get; set;}
        public DateTime CreatedAt { get; set; }
        public DateTime DueDate { get; set; }
    }
}