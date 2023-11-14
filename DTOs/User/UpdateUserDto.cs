using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace taskmanager_api.DTOs.User
{
    public class UpdateUserDto
    {
        public string Username {get; set;} = string.Empty;
        public string Email {get; set;} = string.Empty;
        public byte[] PasswordHash {get; set;} = new byte[0];
        public byte[] PasswordSalt {get; set;} = new byte[0];
        public string Photo {get; set;}
    }
}